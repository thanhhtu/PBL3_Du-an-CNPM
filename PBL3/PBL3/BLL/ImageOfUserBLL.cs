﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;
using System.IO;
using System.Windows.Forms;
using PBL3.DTO.ViewDTO;

namespace PBL3.BLL
{
    public class ImageOfUserBLL
    {
        #region -> Singleton Pattern
        private static DataPBL3 db;
        private static ImageOfUserBLL _Instance;
        public static ImageOfUserBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ImageOfUserBLL();
                return _Instance;
            }
            private set { }
        }
        private ImageOfUserBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        #region -> Add/Delete ImageOfUser
        public void AddImageOfUser(string imagePath, int userID)
        {
            ImageOfUser image = new ImageOfUser()
            {
                ImagePath = imagePath,
                UserID = userID
            };
            db.ImageOfUsers.Add(image);
            db.SaveChanges();
        }

        public void DeleteImageOfUserFromFolder(string appPath)
        {
            appPath = appPath + @"\";
            DirectoryInfo d = new DirectoryInfo(appPath);
            FileInfo[] Files = d.GetFiles();
            foreach (FileInfo file in Files)
            {
                File.Delete(appPath + file.Name);
            }
            Directory.Delete(appPath);
        }
        #endregion

        //Lấy 2 link ảnh
        public List<string> GetImageOfUserPaths(int userID)
        {
            var imagePaths = db.ImageOfUsers.Where(image => image.UserID == userID)
                                        .Select(image => image.ImagePath)
                                        .Take(2)
                                        .ToList();
            return imagePaths;
        }

        //Lấy link tới folder chứa image
        public string GetImageOfUserStoragePath(int? userID)
        {
            if (userID == null) return "";
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string appPath = Path.GetFullPath(Path.Combine(path, @"..\..\")) + @"Resources\Landlord" + userID.ToString();
            return appPath;
        }
    }
}

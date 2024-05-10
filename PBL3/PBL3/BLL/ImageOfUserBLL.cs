using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;
using System.IO;
using System.Windows.Forms;

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

        public List<string> GetImageOfUserPaths(int userID)
        {
            //Lấy ảnh dựa trên userID
            List<string> ls = new List<string>();
            var imageOfUsers = db.ImageOfUsers.Where(i => i.UserID == userID);
            imageOfUsers.ToList().ForEach(i => ls.Add(i.ImagePath));
            return ls.Take(3).ToList();
        }

        public string GetImageOfUserStoragePathsOfPost(int? userID)
        {
            //Lấy đường dẫn của thư mục lưu trữ ảnh của người dùng có UserID
            if (userID == null)
            {
                return "";
            }
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string appPath = Path.GetFullPath(Path.Combine(path, @"..\..\")) + @"Resources\landlord" + userID.ToString();
            return appPath;
        }

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
    }
}

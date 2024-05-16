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
    public class ImageBLL
    {
        #region -> Singleton Pattern
        private static DataPBL3 db;
        private static ImageBLL _Instance;
        public static ImageBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ImageBLL();
                return _Instance;
            }
            private set { }
        }
        private ImageBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        #region -> Add/Delete images
        public void AddImage(string imagePath, int postID)
        {
            Image image = new Image()
            {
                ImagePath = imagePath,
                InforID = postID
            };
            db.Images.Add(image);
            db.SaveChanges();
        }

        public void DeleteImageFromFolder(string appPath)
        {
            appPath = appPath + @"\";
            DirectoryInfo fo = new DirectoryInfo(appPath);
            FileInfo[] files = fo.GetFiles();
            foreach (FileInfo file in files)
            {
                File.Delete(appPath + file.Name); //Xóa file (đường dẫn tới file = đường dẫn tới folder/tên file)
            }
            Directory.Delete(appPath); //Xóa folder
        }

        public void DeleteImageFromPost(int inforID)
        {
            List<Image> images = db.Images.Where(i => i.InforID == inforID).ToList();
            images.ForEach(image => db.Images.Remove(image));
            db.SaveChanges();
        }
        #endregion

        public List<string> GetImagePaths(int inforID)
        {
            var imagePaths = db.Images.Where(image => image.InforID == inforID)
                                        .Select(image => image.ImagePath)
                                        .Take(3) //Chỉ lấy 3 tấm
                                        .ToList();
            return imagePaths;
        }

        //Lấy đường dẫn tới folder chứa image dựa trên InforID
        public string GetImageStoragePathsOfPost(int? inforID)
        {
            if (inforID == null)
            {
                return "";
            }

            string path = Path.GetDirectoryName(Application.ExecutablePath); //Lấy đường dẫn của folder chứa file đang chạy chương trình

            string appPath = Path.GetFullPath(Path.Combine(path, @"..\..\")) //Lên 2 cấp từ folder chứa file đang chạy //Thêm GetFullPath và Combine để tạo đường dẫn 1 cách an toàn hơn 
                            + @"Resources\Infor" + inforID.ToString();
            
            return appPath;
        }
    }
}

using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class FavoriteInforBLL
    {
        #region -> Singleton Pattern
        private static DataPBL3 db;
        private static FavoriteInforBLL _Instance;
        public static FavoriteInforBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new FavoriteInforBLL();
                return _Instance;
            }
            private set { }
        }
        private FavoriteInforBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        #region -> Add/Delete favorite infor
        public void AddFavoriteInfor(int userID, int inforID)
        {
            FavoriteInfor favoriteInfor = new FavoriteInfor()
            {
                UserID = userID,
                InforID = inforID,
            };
            db.FavoriteInfors.Add(favoriteInfor);
            db.SaveChanges();
        }

        public void DeleteFavoriteInfor(int userID, int inforID)
        {
            var fi = db.FavoriteInfors.FirstOrDefault(a => a.UserID == userID && a.InforID == inforID);
            db.FavoriteInfors.Remove(fi);
            db.SaveChanges();
        }

        //Thêm
        public void DeleteAllRentedFavoriteInfor(int userID)
        {
            var favoriteInfors = db.FavoriteInfors.Where(a => a.UserID == userID).ToList();
            foreach(var fi in favoriteInfors)
            {
                if (InforBLL.Instance.IsRentedInfor(fi.InforID)) db.FavoriteInfors.Remove(fi);
                db.SaveChanges();
            }  
        }
        //Thêm
        #endregion

        public bool IsInFavorite(int userID, int inforID)
        {
            return db.FavoriteInfors.Any(fi => fi.UserID == userID && fi.InforID == inforID);
        }

        public List<InforViewDTO> GetFavoriteInfor(int skipNum, int inforNum, int userID)
        {
            List<InforViewDTO> ls = new List<InforViewDTO>();

            using (var dbContext = new DataPBL3()) //Assuming DataPBL3 is your DbContext class //đảm bảo rằng tài nguyên DbContext được giải phóng đúng cách sau khi sử dụng
            {
                var favoriteInfos = dbContext.FavoriteInfors
                             .Where(fi => fi.UserID == userID)
                             .OrderByDescending(fi => fi.InforID)
                             .Skip(skipNum)
                             .Take(inforNum)
                             .ToList();
                foreach (var info in favoriteInfos)
                {
                    var accommodationInfo = info.AccommodationInformation;

                    var inforDTO = new InforViewDTO()
                    {
                        InforID = info.InforID,
                        Title = accommodationInfo.Title,
                        Description = accommodationInfo.Description,
                        SquareArea = accommodationInfo.SquareArea,
                        Price = accommodationInfo.Price,
                        Address = AddressBLL.Instance.GetFullAddress(accommodationInfo.AddressID),
                        UserID = info.UserID,
                        ImagePaths = ImageBLL.Instance.GetImagePaths(info.InforID)
                    };

                    ls.Add(inforDTO);
                }
            }
            return ls;
        }

        //Trả về số lượng favorite infor của người dùng
        public int GetFavoriteCount(int userID)
        {
            int count = db.FavoriteInfors.Where(fi => fi.UserID == userID).Count();
            return count;
        }
    }
}

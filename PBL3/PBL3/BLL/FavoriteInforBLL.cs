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

        public void AddFavourite_Infor(int userID, int inforID)
        {
            FavoriteInfor favorite_Infor = new FavoriteInfor()
            {
                UserID = userID,
                InforID = inforID,
            };
            db.FavoriteInfors.Add(favorite_Infor);
            db.SaveChanges();
        }
        public void DeleteFavourite_Infor(int userID, int inforID)
        {
            var acc = db.FavoriteInfors.FirstOrDefault(a => a.UserID == userID && a.InforID == inforID);
            db.FavoriteInfors.Remove(acc);
            db.SaveChanges();
        }
        public bool IsInFavorite(int userID, int inforID)
        {
            return db.FavoriteInfors.Any(fi => fi.UserID == userID && fi.InforID == inforID);
        }
        // trả về list thông tin bài đăng yêu thích

        public List<InforViewDTO> GetSearchedInfor(int skipNum, int postNum, List<AccommodationInformation> data)
        {
            //Lấy dữ liệu Post đã search được để hiển thị
            List<InforViewDTO> ls = new List<InforViewDTO>();
            data.OrderByDescending(p => p.CreatedTime).Skip(skipNum).Take(postNum)
                .ToList().ForEach(info => ls.Add(new InforViewDTO()
                {
                    InforID = info.InforID,
                    Title = info.Title,
                    Description = info.Description,
                    SquareArea = info.SquareArea,
                    Price = info.Price,
                    Address = AddressBLL.Instance.GetFullAddress(info.AddressID),
                    UserID = info.UserID,
                    ImagePaths = ImageBLL.Instance.GetImagePaths(info.InforID)

                }));
            return ls;
        }

        public List<InforViewDTO> GetFavoriteInfor(int skipNum, int postNum, int userID)
        {
            List<InforViewDTO> ls = new List<InforViewDTO>();

            using (var dbContext = new DataPBL3()) // Assuming DataPBL3 is your DbContext class
            {
                var favoriteInfos = dbContext.FavoriteInfors
                             .Where(fi => fi.UserID == userID)
                             .OrderByDescending(fi => fi.InforID)
                             .Skip(skipNum)
                             .Take(postNum)
                             .ToList();
                foreach (var info in favoriteInfos)
                {
                    // Access the AccommodationInformation navigation property
                    var accommodationInfo = info.AccommodationInformation;

                    var inforDTO = new InforViewDTO()
                    {
                        InforID = info.InforID,
                        Title = accommodationInfo.Title,
                        Description = accommodationInfo.Description,
                        SquareArea = accommodationInfo.SquareArea, // Access SquareArea through AccommodationInformation
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



        // trả về số lượng bài đăng yêu thích của người dùng
        public int GetFavoriteCount(int userID)
        {
            int count = db.FavoriteInfors.Where(fi => fi.UserID == userID).Count();
            return count;
        }

    }
}

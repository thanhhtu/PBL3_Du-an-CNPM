<<<<<<< HEAD
﻿using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
using System;
=======
﻿using System;
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace PBL3.BLL
{
    internal class InforBLL
    {
        #region ->Singleton Pattern
=======
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class InforBLL
    {
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        private static DataPBL3 db;
        private static InforBLL _Instance;
        public static InforBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new InforBLL();
                return _Instance;
            }
            private set { }
        }
        private InforBLL()
        {
            db = new DataPBL3();
        }
        public void LoadApp()
        {
            //tác động lên db để thao tác ban đầu mượt hơn
            db.AccommodationInformations.Count();
        }
<<<<<<< HEAD
        #endregion
        public List<AccommodationInformation> SearchPost(int searchCase, int inputID, int lPrice, int rPrice, float lSquareArea, float rSquareArea)
        {
            List<AccommodationInformation> data = new List<AccommodationInformation>();
            switch (searchCase)
            {
                case 1: //Lấy hết tất cả bài đăng thoã mãn điều kiện
                    data = db.AccommodationInformations.Where(p => p.Price >= lPrice && p.Price <= rPrice
                    && p.SquareArea >= lSquareArea && p.SquareArea <= rSquareArea && p.BeingRented == false).ToList();
                    break;
                case 2: //inputID = id của quận. Lấy hết bài đăng trong quận
                    data = db.AccommodationInformations.Where(p => p.Address.Ward.DistrictID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.SquareArea >= lSquareArea && p.SquareArea <= rSquareArea
                    && p.BeingRented == false).ToList();
                    break;
                case 3: //inputID = id của phường. Lấy hết bài đăng trong phường
                    data = db.AccommodationInformations.Where(p => p.Address.Ward.WardID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.SquareArea >= lSquareArea && p.SquareArea <= rSquareArea
                    && p.BeingRented == false).ToList();
                    break;
                default:
                    data = db.AccommodationInformations.Where(item => item.BeingRented == false).ToList();
                    break;
            }
            return data;
        }
        public List<InforViewDTO> GetSortedPosts(int skipNum, int infoNum, List<AccommodationInformation> data, int sortCase)
        {
            //Sort post trên newsfeed
            List<InforViewDTO> ls = new List<InforViewDTO>();
            List<AccommodationInformation> sorted = new List<AccommodationInformation>();
            switch (sortCase)
            {
                case 0: //Mới nhất
                    sorted = data.OrderByDescending(p => p.CreatedTime).Skip(skipNum).Take(infoNum).ToList();
                    break;
                case 1: //Cũ nhất
                    sorted = data.OrderBy(p => p.CreatedTime).Skip(skipNum).Take(infoNum).ToList();
                    break;
                case 2: //Giá từ thấp đến cao
                    sorted = data.OrderBy(p => p.Price).Skip(skipNum).Take(infoNum).ToList();
                    break;
                case 3: //Giá từ cao đến thấp
                    sorted = data.OrderByDescending(p => p.Price).Skip(skipNum).Take(infoNum).ToList();
                    break;
                case 4: //Diện tích từ nhỏ đến lớn
                    sorted = data.OrderBy(p => p.SquareArea).Skip(skipNum).Take(infoNum).ToList();
                    break;
                case 5: //Diện tích từ lớn đến nhỏ
                    sorted = data.OrderByDescending(p => p.SquareArea).Skip(skipNum).Take(infoNum).ToList();
                    break;
                default:
                    sorted = data.OrderByDescending(p => p.CreatedTime).Skip(skipNum).Take(infoNum).ToList();
                    break;
            }
            sorted.ForEach(post => ls.Add(
                new InforViewDTO()
                {
                    InforID = post.InforID,
                    Title = post.Title,
                    Description = post.Description,
                    SquareArea = post.SquareArea,
                    Price = post.Price,
                    Address = AddressBLL.Instance.GetFullAddress(post.AddressID),
                    UserID = post.UserID,
                    ImagePaths = ImageBLL.Instance.GetImagePaths(post.InforID)
                }));
            return ls;
        }
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
        public InforViewDTO GetPostByID(int postID)
        {
            var info = db.AccommodationInformations.FirstOrDefault(p => p.InforID == postID);
            return new InforViewDTO()
            {
                InforID = info.InforID,
                Title = info.Title,
                Description = info.Description,
                SquareArea = info.SquareArea,
                Price = info.Price,
                Address = AddressBLL.Instance.GetFullAddress(info.AddressID),
                UserID = info.UserID,
                ImagePaths = ImageBLL.Instance.GetImagePaths(info.InforID),
                LivingWithOwner = info.LivingWithOwner.HasValue ? info.LivingWithOwner.Value : false,
                Deposit = info.Deposit.HasValue ? info.Deposit.Value : 0


            };
        }
        public string GetPublishedTime(int inforID)
        {
            var p = db.AccommodationInformations.FirstOrDefault(post => post.InforID == inforID);
            string datetime = p.CreatedTime.ToString();
            return datetime;
        }
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
    }

=======
    }
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
}

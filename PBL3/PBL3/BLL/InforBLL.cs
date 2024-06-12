using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace PBL3.BLL
{
    internal class InforBLL
    {
        public void LoadApp() //Tác động lên db để thao tác ban đầu
        {
            db.AccommodationInformations.ToList();
        }

        #region -> Singleton Pattern
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
        #endregion

        #region -> Add/Update/Delete infor
        public int AddInfor(AccommodationInformation infor)
        {
            db.AccommodationInformations.Add(infor);
            db.SaveChanges();
            return infor.InforID;
        }

        public void UpdateInfor(AccommodationInformation editedInfor)
        {
            AccommodationInformation infor = db.AccommodationInformations.FirstOrDefault(c => c.InforID == editedInfor.InforID);
            infor.Title = editedInfor.Title;
            infor.Description = editedInfor.Description;
            infor.Price = editedInfor.Price;
            infor.Deposit = editedInfor.Deposit;
            infor.SquareArea = editedInfor.SquareArea;
            infor.LivingWithOwner = editedInfor.LivingWithOwner;
            infor.BeingRented = editedInfor.BeingRented;
            infor.ModifiedTime = editedInfor.ModifiedTime;
            db.SaveChanges();
        }

        public void DeleteInfor(int inforID)
        {
            AccommodationInformation infor = db.AccommodationInformations.FirstOrDefault(c => c.InforID == inforID);
            var temp = infor.AddressID;
            db.AccommodationInformations.Remove(infor);
            db.SaveChanges();

            ImageBLL.Instance.DeleteImageFromFolder(ImageBLL.Instance.GetImageStoragePathsOfInfor(inforID));
            AddressBLL.Instance.DeleteAddress(temp);
        }

        public void DeleteInforOfUser(int userID)
        {
            var ls = db.AccommodationInformations.Where(c => c.UserID == userID).ToList();
            ls.ForEach(info => DeleteInfor(info.InforID));
            db.SaveChanges();
        }
        #endregion

        #region -> Management infor
        public List<InforDTGViewDTO> GetDTGView(int searchFilter, int sortCase, bool checkAscending, string searchChars, int userID = -1)
        {
            List<InforDTGViewDTO> data = new List<InforDTGViewDTO>();
            switch (searchFilter)
            {
                case 0: //Tất cả 
                    data = InforBLL.Instance.GetAllInforView(userID);
                    break;
                case 1: //Chưa cho thuê
                    data = InforBLL.Instance.GetRentedInfor(false, userID);
                    break;
                case 2: //Đã cho thuê
                    data = InforBLL.Instance.GetRentedInfor(true, userID);
                    break;
                case 3: //Đã chỉnh sửa
                    data = InforBLL.Instance.GetEditedInfor(userID);
                    break;
                default:
                    data = InforBLL.Instance.GetAllInforView();
                    break;
            }
            List<InforDTGViewDTO> temp = InforBLL.Instance.SearchByChars(searchChars, data);
            List<InforDTGViewDTO> result = InforBLL.Instance.SortResult(sortCase, checkAscending, temp);
            return result;
        }

        public InforDTGViewDTO GetInforDTGView(AccommodationInformation infor)
        {
            return new InforDTGViewDTO
            {
                InforID = infor.InforID,
                UserID = infor.UserID,
                Username = UserBLL.Instance.GetUserFullname(infor.UserID),
                Title = infor.Title,
                Address = AddressBLL.Instance.GetFullAddress(infor.AddressID),
                NumberOfComment = InforBLL.Instance.GetNumOfCommentInInfor(infor.InforID),
                BeingRented = InforBLL.Instance.CheckRented(infor.InforID),
                CreatedTime = infor.CreatedTime,
                ModifiedTime = infor.ModifiedTime
            };
        }

        //Lấy tất cả infor trong hệ thống, hoặc tất cả infor của 1 landlord
        public List<InforDTGViewDTO> GetAllInforView(int userID = -1)
        {
            List<InforDTGViewDTO> data = new List<InforDTGViewDTO>();

            if (userID == -1) //Lấy tất cả infor trong hệ thống -> dành cho Admin
            {
                db.AccommodationInformations.ToList()
                    .ForEach(infor => data.Add(GetInforDTGView(infor)));
            }
            else //Lấy tất cả infor của 1 landlord đang đăng nhập
            {
                db.AccommodationInformations.Where(i => i.UserID == userID).ToList()
                    .ForEach(infor => data.Add(GetInforDTGView(infor)));
            }
            return data;
        }

        //Lấy các bài infor đã được chủ trọ cập nhật là đã cho thuê
        public List<InforDTGViewDTO> GetRentedInfor(bool rentedStatus, int userID = -1)
        {
            List<InforDTGViewDTO> data = new List<InforDTGViewDTO>();

            if (userID == -1) //Lấy tất cả infor trong hệ thống -> dành cho admin
            {
                db.AccommodationInformations.Where(p => p.BeingRented == rentedStatus).ToList()
                    .ForEach(infor => data.Add(GetInforDTGView(infor)));
            }
            else //Lấy infor của landlord đang đăng nhập
            {
                db.AccommodationInformations.Where(i => i.UserID == userID && i.BeingRented == rentedStatus).ToList()
                    .ForEach(infor => data.Add(GetInforDTGView(infor)));
            }

            return data;
        }

        //Lấy các bài infor đã được chỉnh sửa 
        public List<InforDTGViewDTO> GetEditedInfor(int userID = -1)
        {
            if (userID == -1) //Lấy tất cả infor trong hệ thống -> dành cho admin
            {
                List<InforDTGViewDTO> data = new List<InforDTGViewDTO>();
                db.AccommodationInformations.Where(i => i.ModifiedTime != null).ToList()
                    .ForEach(infor => data.Add(GetInforDTGView(infor)));
                return data;
            }
            else //Lấy infor của landlord đang đăng nhập
            {
                List<InforDTGViewDTO> data = new List<InforDTGViewDTO>();
                db.AccommodationInformations.Where(p => p.UserID == userID && p.ModifiedTime != null).ToList()
                    .ForEach(infor => data.Add(GetInforDTGView(infor)));
                return data;
            }
        }

        //Từ dữ liệu search, lọc ra những infor chứa char người dùng đã nhập
        public List<InforDTGViewDTO> SearchByChars(string searchChar, List<InforDTGViewDTO> data)
        {
            List<InforDTGViewDTO> result = new List<InforDTGViewDTO>();
            foreach (var i in data)
            {
                if (i.Username.Contains(searchChar) || i.Title.Contains(searchChar) || i.Address.Contains(searchChar))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public List<InforDTGViewDTO> SortResult(int sortCase, bool checkAscending, List<InforDTGViewDTO> data)
        {
            List<InforDTGViewDTO> result = new List<InforDTGViewDTO>();
            switch (sortCase)
            {
                case 0: //Thời gian tạo
                    result = data.OrderByDescending(p => p.CreatedTime).ToList();
                    break;
                case 1: //Thời gian chỉnh sửa
                    result = data.OrderBy(p => p.ModifiedTime).ToList();
                    break;
                case 2: //Số comment
                    result = data.OrderBy(p => p.NumberOfComment).ToList();
                    break;
                default: //Thời gian tạo
                    result = data.OrderByDescending(p => p.CreatedTime).ToList();
                    break;
            }

            if (!checkAscending) //Nếu checkAscending == false -> sắp xếp ngược lại
            {
                result.Reverse();
            }
            return result;
        }
        #endregion

        public List<AccommodationInformation> SearchInfor(int searchCase, int inputID, int lPrice, int rPrice, float lSquareArea, float rSquareArea)
        {
            List<AccommodationInformation> data = new List<AccommodationInformation>();
            switch (searchCase)
            {
                case 1: //Lấy hết tất cả infor thỏa mãn điều kiện
                    data = db.AccommodationInformations.Where(p => p.Price >= lPrice && p.Price <= rPrice
                    && p.SquareArea >= lSquareArea && p.SquareArea <= rSquareArea && p.BeingRented == false).ToList();
                    break;
                case 2: //inputID = id của quận. Lấy hết infor trong quận
                    data = db.AccommodationInformations.Where(p => p.Address.Ward.DistrictID == inputID && p.Price >= lPrice
                    && p.Price <= rPrice && p.SquareArea >= lSquareArea && p.SquareArea <= rSquareArea
                    && p.BeingRented == false).ToList();
                    break;
                case 3: //inputID = id của phường. Lấy hết infor trong phường
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

        //Lấy dữ liệu infor đã search được để hiển thị
        public List<InforViewDTO> GetSearchedInfor(int skipAllNum, int inforNum, List<AccommodationInformation> data)
        {
            List<InforViewDTO> ls = new List<InforViewDTO>();

            data.OrderByDescending(i => GetRentedTime(i) ?? i.CreatedTime).Skip(skipAllNum).Take(inforNum)
                .ToList()
                .ForEach(info => ls.Add(new InforViewDTO()
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

        public DateTime? GetRentedTime(AccommodationInformation infor)
        {
            var rentedInfor = db.ModifierHistorys.Where(i => i.InforID == infor.InforID)
                .OrderByDescending(i => i.ModifiedTime)
                .FirstOrDefault();

            if (rentedInfor == null) return null;
            return rentedInfor.ModifiedTime;
        }

        //Sort infor trên dashboard
        public List<InforViewDTO> GetSortedInfors(int skipNum, int infoNum, List<AccommodationInformation> data, int sortCase)
        {
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

        public InforViewDTO GetInforByID(int inforID)
        {
            var info = db.AccommodationInformations.FirstOrDefault(p => p.InforID == inforID);
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
                LivingWithOwner = info.LivingWithOwner,
                Deposit = info.Deposit
            };
        }

        public string CheckRented(int inforID)
        {
            bool a = db.AccommodationInformations.FirstOrDefault(p => p.InforID == inforID).BeingRented;
            if (a) return "Đã thuê";
            else return "Chưa thuê";
        }

        public string GetPublishedTime(int inforID)
        {
            var i = db.AccommodationInformations.FirstOrDefault(p => p.InforID == inforID);
            string datetime = i.CreatedTime.ToString();
            return datetime;
        }

        public int? GetAddressIDByInforID(int inforID)
        {
            return db.AccommodationInformations.FirstOrDefault(c => c.InforID == inforID).AddressID;
        }
        
        public bool CheckLivingwOwner(int inforID)
        {
            return db.AccommodationInformations.FirstOrDefault(c => c.InforID == inforID).LivingWithOwner;
        }

        public int GetNumOfCommentInInfor(int inforID)
        {
            var data = db.Comments.Where(c => c.InforID == inforID).ToList();
            if (data == null) return 0;
            return data.Count();
        }

        public string GetInforTitle(int inforID)
        {
            var i = db.AccommodationInformations.FirstOrDefault(p => p.InforID == inforID);
            string title = i.Title;
            return title;
        }
    }
}

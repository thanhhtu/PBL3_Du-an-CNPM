using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;


namespace PBL3.BLL
{
    public class UserBLL
    {
        #region -> Singleton Pattern
        private static DataPBL3 db;
        private static UserBLL _Instance;
        public static UserBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new UserBLL();
                return _Instance;
            }
            private set { }
        }
        private UserBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        #region -> Add/Update/Delete/Publish/Pause User
        public int AddUser(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
            return newUser.UserID;
        }

        public void UpdateUserInformation(User userInfo, Address addInfo)
        {
            User user = db.Users.FirstOrDefault(u => u.UserID == userInfo.UserID);
            user.FullName = userInfo.FullName;
            user.Phone = userInfo.Phone;
            user.Email = userInfo.Email;
            AddressBLL.Instance.UpdateAddress(user.AddressID, addInfo);
            db.SaveChanges();
        }

        public void DeleteUser(int userID)
        {
            //Đầu tiên là xóa infor, sau đó xóa account và address
            //Các dữ liệu theo các key phụ thuộc giữa các bảng sẽ bị xóa theo
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            InforBLL.Instance.DeleteInforOfUser(user.UserID);
            AccountBLL.Instance.DeleteAccount(user.AccountID);
            AddressBLL.Instance.DeleteAddress(user.AddressID);
            db.SaveChanges();
        }

        public void PublishUser(int userID)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            AccountBLL.Instance.Published(user.AccountID);
        }

        //tt thêm    
        public void PauseUser(int userID)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            AccountBLL.Instance.PauseAccount(user.AccountID);

            //Xóa infor
            InforBLL.Instance.DeleteInforOfUser(userID);
        }
        
        public void ActiveUser(int userID)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            AccountBLL.Instance.ActiveAccount(user.AccountID);
        }
        //
        #endregion

        #region -> Management user 
        //tt đổi
        public List<UserViewDTO> SearchUser(string searchChars, int userRole, int sortCase, bool checkAscending, bool? beingPublished, bool beingPaused)
        {
            List<UserViewDTO> data = new List<UserViewDTO>();

            switch (userRole)
            {
                case 0: //Tất cả 
                    data = UserBLL.Instance.GetAllUserView();
                    break;
                case 1: //Người cho thuê (Đã được duyệt)
                    data = UserBLL.Instance.GetLandlord(true);
                    break;
                case 2: //Người cho thuê (Chưa được duyệt)
                    data = UserBLL.Instance.GetLandlord(false);
                    break;
                case 3: //Người đi thuê
                    data = UserBLL.Instance.GetRenter();
                    break;
                case 4: //Tài khoản bị ngừng hoạt động
                    data = UserBLL.Instance.GetPausedUser();
                    break;
                default:
                    data = UserBLL.Instance.GetAllUserView();
                    break;
            }

            //Sau khi get ra, search theo char + rolename và sort lại kết quả 
            List<UserViewDTO> temp = UserBLL.Instance.SearchCharsAndRoleName(searchChars, userRole, data, beingPublished, beingPaused);
            List<UserViewDTO> result = UserBLL.Instance.SortResult(sortCase, checkAscending, temp);
            return result;
        }

        public UserViewDTO SetUserView(User u)
        {
            return new UserViewDTO
            {
                UserID = u.UserID,
                Rolename = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
                Fullname = u.FullName,
                Email = u.Email,
                Phone = u.Phone,
                Address = AddressBLL.Instance.GetFullAddress(u.AddressID),
                NumberOfInfor = UserBLL.Instance.CountUserPost(u.UserID),
                NumberOfComment = UserBLL.Instance.CountUserCMT(u.UserID),
                JoinedAt = AccountBLL.Instance.GetCreatedAt(u.AccountID),
                BeingPublished = AccountBLL.Instance.GetBeingPublished(u.AccountID),
                PublishedAt = AccountBLL.Instance.GetPublishedAt(u.AccountID), //thêm
                BeingPaused = AccountBLL.Instance.GetBeingPaused(u.AccountID), //tt thêm
            };
        }

        public List<UserViewDTO> GetAllUserView()
        {
            List<UserViewDTO> data = new List<UserViewDTO>();
            
            db.Users.Where(u => u.Account.RoleID == 2 || u.Account.RoleID == 3).ToList()
                .ForEach(user => data.Add(SetUserView(user)));
            return data;
        }

        public List<UserViewDTO> GetLandlord(bool publishedStatus)
        {
            List<UserViewDTO> data = new List<UserViewDTO>();

            db.Users.Where(u => u.Account.RoleID == 2 && u.Account.BeingPublished == publishedStatus).ToList()
                .ForEach(user => data.Add(SetUserView(user)));
 
            return data;
        }

        public List<UserViewDTO> GetRenter()
        {
            List<UserViewDTO> data = new List<UserViewDTO>();

            db.Users.Where(u => u.Account.RoleID == 3).ToList()
                .ForEach(user => data.Add(SetUserView(user)));

            return data;
        }

        public List<UserViewDTO> GetPausedUser()
        {
            List<UserViewDTO> data = new List<UserViewDTO>();

            db.Users.Where(u => (u.Account.RoleID == 2 || u.Account.RoleID == 3) && u.Account.BeingPaused == true).ToList()
                .ForEach(user => data.Add(SetUserView(user)));

            return data;
        }

        public List<UserViewDTO> SearchCharsAndRoleName(string searchChars, int userRole, List<UserViewDTO> data, bool? beingPublished, bool beingPaused)
        {
            List<UserViewDTO> result = new List<UserViewDTO>();
            foreach (var i in data)
            {
                if (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public List<UserViewDTO> SortResult(int sortCase, bool checkAscending, List<UserViewDTO> data)
        {
            List<UserViewDTO> result = new List<UserViewDTO>();
            switch (sortCase)
            {
                /*Thời gian tham gia
                Số comment
                Thời gian được duyệt
                Số phòng trọ*/
                case 0: //Thời gian tham gia
                    result = data.OrderBy(u => u.JoinedAt).ToList();
                    break;
                case 1: //Thời gian được duyệt
                    result = data.OrderBy(u => u.PublishedAt).ToList();
                    break;
                case 2: //Số comment
                    result = data.OrderBy(u => u.NumberOfComment).ToList();
                    break;
                case 3: //Số infor
                    result = data.OrderBy(u => u.NumberOfInfor).ToList();
                    break;
                default: //Thời gian tham gia
                    result = data.OrderBy(u => u.JoinedAt).ToList();
                    break;
            }
            if (!checkAscending)
            {
                //sort descending
                result.Reverse();
            }
            return result;
        }
        //tt đổi
        #endregion

        public int GetAddressIDByUserID(int userID)
        {
            return db.Users.FirstOrDefault(user => user.UserID == userID).AddressID;
        }

        public int GetRoleIDByUserID(int userID)
        {
            //userID = -1 khi chưa đăng nhập vào hệ thống
            if (userID == -1) return -1;
            int accountID = db.Users.FirstOrDefault(user => user.UserID == userID).AccountID;
            int roleID = AccountBLL.Instance.GetRoleIDByAccountID(accountID);
            return roleID;
        }

        public int GetUserIDByAccountID(int accountId)
        {
            var user = db.Users.FirstOrDefault(p => p.AccountID == accountId);
            if (user != null) return user.UserID;
            return -1;
        }

        public User GetUserByID(int? userID)
        {
            if (userID == null) return null;
            return db.Users.FirstOrDefault(u => u.UserID == userID);
        }

        public int GetAccountIDByUserID(int userID)
        {
            return db.Users.FirstOrDefault(user => user.UserID == userID).AccountID;
        }

        public string GetUserFullname(int? userID)
        {
            if (userID == null) return "";
            return db.Users.FirstOrDefault(user => user.UserID == userID).FullName;
        }

        public int CountUserPost(int userID)
        {
            var userpost = db.AccommodationInformations.Where(p => p.UserID == userID).ToList();
            if (userpost == null) return 0;
            else return userpost.Count();
        }

        public int CountUserCMT(int userID)
        {
            var usercmt = db.Comments.Where(c => c.UserID == userID).ToList();
            if (usercmt == null) return 0;
            else return usercmt.Count();
        }

        //tt thêm
        public bool IsPublishedAccount(int userID)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            return AccountBLL.Instance.IsPublishedAccount(user.AccountID);
        }

        public bool IsPausedAccount(int userID)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            return AccountBLL.Instance.IsPausedAccount(user.AccountID);
        }
        //
    }
}

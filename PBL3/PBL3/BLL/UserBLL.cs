using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Windows.Forms;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;

=======
using PBL3.DTO;
using PBL3.DAL;
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3

namespace PBL3.BLL
{
    public class UserBLL
    {
        #region ->Singleton Pattern
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

        public int GetAddressIDByUserID(int userID)
        {
            return db.Users.FirstOrDefault(user => user.UserID == userID).AddressID;
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public int GetRoleIDByUserID(int userID)
        {
            //userID = -1 khi chưa đăng nhập vào hệ thống
            if (userID == -1)
<<<<<<< HEAD
                return -1;
=======
            {
                return -1;
            }
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
            int accountID = db.Users.FirstOrDefault(user => user.UserID == userID).AccountID;
            int roleID = AccountBLL.Instance.GetRoleIDByAccountID(accountID);
            return roleID;
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public int GetUserIDByAccountID(int accountId)
        {
            var user = db.Users.FirstOrDefault(p => p.AccountID == accountId);
            if (user != null)
            {
                return user.UserID;
            }
            return -1;
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public User GetUserByID(int? userID)
        {
            if (userID == null)
                return null;
            return db.Users.FirstOrDefault(u => u.UserID == userID);
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public int GetAccountIDByUserID(int userID)
        {
            return db.Users.FirstOrDefault(user => user.UserID == userID).AccountID;
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public string GetUserFullname(int? userID)
        {
            if (userID == null) return "";
            return db.Users.FirstOrDefault(user => user.UserID == userID).FullName;
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public int CountUserPost(int userID)
        {
            var userpost = db.AccommodationInformations.Where(p => p.UserID == userID).ToList();
            if (userpost == null) return 0;
            else
            {
                return userpost.Count();
            }
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public int CountUserCMT(int userID)
        {
            var usercmt = db.Comments.Where(c => c.UserID == userID).ToList();
            if (usercmt == null) return 0;
            else
            {
                return usercmt.Count();
            }
        }

        #region ->User DTG Management
<<<<<<< HEAD
        // đạt thêm publised at 
        public List<UserViewDTO> SearchUser(string searchChars, string rolename, int sortCase, bool checkAscending,bool? published)
        {
            List<UserViewDTO> data = new List<UserViewDTO>();
            var raw = db.Users.ToList();
            foreach (var u in raw)
            {
                int roleID = AccountBLL.Instance.GetRoleIDByAccountID(u.AccountID);
                if (roleID == 2 || roleID == 3)
                {
                    data.Add(new UserViewDTO
                    {
                        UserID = u.UserID,
                        Rolename = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
                        Fullname = u.FullName,
                        Email = u.Email,
                        Phone = u.Phone,
                        Address = AddressBLL.Instance.GetFullAddress(u.AddressID),
                        NumberOfPost = UserBLL.Instance.CountUserPost(u.UserID),
                        NumberOfComment = UserBLL.Instance.CountUserCMT(u.UserID),
                        JoinedAt = AccountBLL.Instance.GetCreatedAt(u.AccountID),
                        BeingPublished = AccountBLL.Instance.GetBeingPublished(u.AccountID),
                        Publishedat = AccountBLL.Instance.GetPublishedAt(u.AccountID),
                    });
                }
            }
            //Sau khi get ra, search theo char + rolename và sort lại kết quả 
            List<UserViewDTO> temp = UserBLL.Instance.SearchCharsAndRoleName(searchChars, rolename, data, published);
            List<UserViewDTO> result = UserBLL.Instance.SortResult(sortCase, checkAscending, temp);
            return result;
        }
        // đạt sửa 
        public List<UserViewDTO> SearchCharsAndRoleName(string searchChars, string rolename, List<UserViewDTO> data, bool? published)
        {
            //Sau khi search theo filter, lọc các kết quả chứa char và có rolename cần tìm
            List<UserViewDTO> result = new List<UserViewDTO>();
            if (rolename == "All")
            {
                foreach (var i in data)
                {
                    if (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars))
                    {
                        result.Add(i);
                    }
                }
                return result;
            }
            else
            {
                if (published == true)
                {
                    {
                        foreach (var i in data)
                        {
                            if ((i.BeingPublished == true) && (i.Rolename == rolename) && (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars)))
                            {
                                result.Add(i);
                            }
                        }
                        return result;
                    }
                }
                else
                {
                    foreach (var i in data)
                    {
                        if ((i.BeingPublished == false) && (i.Rolename == rolename) && (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars)))
                        {
                            result.Add(i);
                        }
                    }
                    return result;
                }
            }
        }
        public List<UserViewDTO> SortResult(int sortCase, bool checkAscending, List<UserViewDTO> data)
        {
            List<UserViewDTO> result = new List<UserViewDTO>();
            switch (sortCase)
            {
                case 0: // Thời gian tham gia
                    result = data.OrderBy(p => p.JoinedAt).ToList();
                    break;
                case 1: // Số bài post
                    result = data.OrderBy(p => p.NumberOfPost).ToList();
                    break;
                case 2: //Số comment
                    result = data.OrderBy(p => p.NumberOfComment).ToList();
                    break;
            }
            if (!checkAscending)
            {
                //sort descending
                result.Reverse();
            }
            return result;
        }
        #endregion

        #region ->Add/Update/Delete User/Published
        public void published (int userID)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            AccountBLL.Instance.published(user.AccountID);
        }
=======
        //public List<UserViewDTO> SearchUser(string searchChars, string rolename, int sortCase, bool checkAscending)
        //{
        //    List<UserViewDTO> data = new List<UserViewDTO>();
        //    var raw = db.Users.ToList();
        //    foreach (var u in raw)
        //    {
        //        int roleID = AccountBLL.Instance.GetRoleIDByAccountID(u.AccountID);
        //        if (roleID == 2 || roleID == 3)
        //        {
        //            data.Add(new UserViewDTO
        //            {
        //                UserID = u.UserID,
        //                Rolename = AccountBLL.Instance.GetRoleNameByAccountID(u.AccountID),
        //                Fullname = u.FullName,
        //                Email = u.Email,
        //                Phone = u.Phone,
        //                Address = AddressBLL.Instance.GetFullAddress(u.AddressID),
        //                NumberOfPost = UserBLL.Instance.CountUserPost(u.UserID),
        //                NumberOfComment = UserBLL.Instance.CountUserCMT(u.UserID),
        //                JoinedAt = AccountBLL.Instance.GetCreatedAt(u.AccountID)
        //            });
        //        }
        //    }
        //    //Sau khi get ra, search theo char + rolename và sort lại kết quả 
        //    List<UserViewDTO> temp = UserBLL.Instance.SearchCharsAndRoleName(searchChars, rolename, data);
        //    List<UserViewDTO> result = UserBLL.Instance.SortResult(sortCase, checkAscending, temp);
        //    return result;
        //}
        //public List<UserViewDTO> SearchCharsAndRoleName(string searchChars, string rolename, List<UserViewDTO> data)
        //{
        //    //Sau khi search theo filter, lọc các kết quả chứa char và có rolename cần tìm
        //    List<UserViewDTO> result = new List<UserViewDTO>();
        //    if (rolename == "All")
        //    {
        //        foreach (var i in data)
        //        {
        //            if (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars))
        //            {
        //                result.Add(i);
        //            }
        //        }
        //        return result;
        //    }
        //    else
        //    {
        //        foreach (var i in data)
        //        {
        //            if ((i.Rolename == rolename) && (i.Address.Contains(searchChars) || i.Fullname.Contains(searchChars) || i.Phone.Contains(searchChars) || i.Email.Contains(searchChars)))
        //            {
        //                result.Add(i);
        //            }
        //        }
        //        return result;
        //    }
        //}
        //public List<UserViewDTO> SortResult(int sortCase, bool checkAscending, List<UserViewDTO> data)
        //{
        //    List<UserViewDTO> result = new List<UserViewDTO>();
        //    switch (sortCase)
        //    {
        //        case 0: // Thời gian tham gia
        //            result = data.OrderBy(p => p.JoinedAt).ToList();
        //            break;
        //        case 1: // Số bài post
        //            result = data.OrderBy(p => p.NumberOfPost).ToList();
        //            break;
        //        case 2: //Số comment
        //            result = data.OrderBy(p => p.NumberOfComment).ToList();
        //            break;
        //    }
        //    if (!checkAscending)
        //    {
        //        //sort descending
        //        result.Reverse();
        //    }
        //    return result;
        //}
        #endregion

        #region ->Add/Update/Delete User
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public int AddUser(User newUser)
        {
            db.Users.Add(newUser);
            db.SaveChanges();
            return newUser.UserID;
        }
<<<<<<< HEAD
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
            //Đầu tiên là xóa post, sau đó xóa account và address
            //Các dữ liệu theo các key phụ thuộc giữa các bảng sẽ bị xóa theo
            var user = db.Users.FirstOrDefault(u => u.UserID == userID);
            //PostBLL.Instance.DeleteUserPost(user.UserID);
            AccountBLL.Instance.DeleteAccount(user.AccountID);
            AddressBLL.Instance.DeleteAddress(user.AddressID);
            db.SaveChanges();
        }
=======

        //public void UpdateUserInformation(User userInfo, Address addInfo)
        //{
        //    User user = db.Users.FirstOrDefault(u => u.UserID == userInfo.UserID);
        //    user.FullName = userInfo.FullName;
        //    user.Phone = userInfo.Phone;
        //    user.Email = userInfo.Email;
        //    AddressBLL.Instance.UpdateAddress(user.AddressID, addInfo);
        //    db.SaveChanges();
        //}
        //public void DeleteUser(int userID)
        //{
        //    //Đầu tiên là xóa post, sau đó xóa account và address
        //    //Các dữ liệu theo các key phụ thuộc giữa các bảng sẽ bị xóa theo
        //    var user = db.Users.FirstOrDefault(u => u.UserID == userID);
        //    InforBLL.Instance.DeleteUserPost(user.UserID);
        //    AccountBLL.Instance.DeleteAccount(user.AccountID);
        //    AddressBLL.Instance.DeleteAddress(user.AddressID);
        //    db.SaveChanges();
        //}
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        #endregion
    }
}

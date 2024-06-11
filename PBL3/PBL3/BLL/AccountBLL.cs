using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;
using System.Runtime.InteropServices;

namespace PBL3.BLL
{
    public class AccountBLL
    {
        #region -> Singleton Pattern
        private static DataPBL3 db;
        private static AccountBLL _Instance;
        public static AccountBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AccountBLL();
                return _Instance;
            }
            private set { }
        }
        private AccountBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        #region -> Add/Delete/Publish/Pause/Active account
        public int AddAccount(Account newAccount)
        {
            db.Accounts.Add(newAccount);
            db.SaveChanges();
            return newAccount.AccountID;
        }

        public void DeleteAccount(int accountID)
        {
            var acc = db.Accounts.FirstOrDefault(a => a.AccountID == accountID);
            db.Accounts.Remove(acc);
            db.SaveChanges();
        }

        public void PublishAccount(int accountID)
        {
            Account acc = db.Accounts.FirstOrDefault(a => a.AccountID == accountID);
            acc.BeingPublished = true;
            acc.PublishedTime = DateTime.Now;
            db.SaveChanges();
        }

        public void PauseAccount(int accountID)
        {
            Account acc = db.Accounts.FirstOrDefault(a => a.AccountID == accountID);
            acc.BeingPaused = true;
            db.SaveChanges();
        }

        public void ActiveAccount(int accountID)
        {
            Account acc = db.Accounts.FirstOrDefault(a => a.AccountID == accountID);
            acc.BeingPaused = false;
            db.SaveChanges();
        }
        #endregion

        public void ChangePassword(int accountID, string newPassword)
        {
            Account acc = db.Accounts.FirstOrDefault(a => a.AccountID == accountID);
            acc.Pwd = PwdHashing.EncodePwdToBase64(newPassword);
            db.SaveChanges();
        }

        //Kiểm tra chủ trọ đã được duyệt chưa (true: đã duyệt)
        public bool IsPublishedAccount(int accountID)
        {
            return db.Accounts.Any(a => a.AccountID == accountID && a.BeingPublished == true);
        }

        //Kiểm tra tài khoản có bị admin dừng hoạt động không (true: bị dừng)
        public bool IsPausedAccount(int accountID)
        {
            return db.Accounts.Any(a => a.AccountID == accountID && a.BeingPaused == true);
        }

        public bool CheckExistingUsername(string username)
        {
            return db.Accounts.Any(p => p.Username == username);
        }

        public bool CheckPassword(int accountID, string password)
        {
            foreach (var account in db.Accounts)
            {
                if (account.AccountID == accountID && PwdHashing.DecodePwdFromBase64(account.Pwd) == password)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetRole(string username, string password)
        {
            foreach (var account in db.Accounts)
            {
                if (account.Username == username && PwdHashing.DecodePwdFromBase64(account.Pwd) == password)
                {
                    return account.RoleID;
                }
            }
            return 0;
        }

        public string GetRoleNameByAccountID(int accID)
        {
            var acc = db.Accounts.FirstOrDefault(a => a.AccountID == accID);
            if (acc != null)
            {
                if (acc.RoleID == 2) return "Người cho thuê";
                if (acc.RoleID == 3) return "Người thuê";
                return "Quản trị viên";
            }
            else
            {
                return "";
            }
        }

        public int GetRoleIDByAccountID(int accountID)
        {
            return db.Accounts.FirstOrDefault(account => account.AccountID == accountID).RoleID;
        }

        public int GetAccountID(string username, string password)
        {
            foreach (var account in db.Accounts)
            {
                if (account.Username == username && PwdHashing.DecodePwdFromBase64(account.Pwd) == password)
                {
                    return account.AccountID;
                }
            }
            return -1;
        }

        public DateTime GetCreatedTime(int accID)
        {
            return db.Accounts.FirstOrDefault(account => account.AccountID == accID).CreatedTime;
        }

        public string GetBeingPublished(int accID)
        {
            bool a = db.Accounts.FirstOrDefault(account => account.AccountID == accID).BeingPublished;
            if (a) return "Đã Duyệt";
            else return "Chưa Duyệt";
        }

        public DateTime? GetPublishedTime(int accID)
        {
            return db.Accounts.FirstOrDefault(account => account.AccountID == accID).PublishedTime;
        }

        public string GetBeingPaused(int accID)
        {
            bool a = db.Accounts.FirstOrDefault(account => account.AccountID == accID).BeingPaused;
            if (a) return "Ngừng hoạt động";
            else return "Hoạt động";
        }
    }
}

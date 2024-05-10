using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

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

        #region -> Change Pwd and Add/Delete/Accept Account
        public void ChangePassword(int accountID, string newPassword)
        {
            Account acc = db.Accounts.Where(a => a.AccountID == accountID).FirstOrDefault();
            acc.Pwd = PwdHashing.EncodePwdToBase64(newPassword);
            db.SaveChanges();
        }

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

        public bool IsAcceptedAccount(int accountID)
        {
            var acc = db.Accounts.FirstOrDefault(a => a.AccountID == accountID && a.BeingPublished == true);
            if (acc == null) return false;
            return true;
        }
        #endregion

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

        public DateTime GetCreatedAt(int accID)
        {
            return db.Accounts.FirstOrDefault(account => account.AccountID == accID).CreatedAt;
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
        public void published(int accountID)
        {
            Account acc = db.Accounts.Where(a => a.AccountID == accountID).FirstOrDefault();
            acc.BeingPublished = true;
            db.SaveChanges();
        }
        public bool? GetBeingPublished(int accID)
        {
            return db.Accounts.FirstOrDefault(account => account.AccountID == accID).BeingPublished;
        }
        // đạt thêm 
        public DateTime? GetPublishedAt(int accID)
        {
            return db.Accounts.FirstOrDefault(account => account.AccountID == accID).PublishedAt;
        }
    }
}

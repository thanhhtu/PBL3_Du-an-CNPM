using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class ModifiedHistoryBLL
    {
        #region -> Singleton Pattern
        private static DataPBL3 db;
        private static ModifiedHistoryBLL _Instance;
        public static ModifiedHistoryBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ModifiedHistoryBLL();
                return _Instance;
            }
            private set { }
        }
        private ModifiedHistoryBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        #region 
        public void AddModified(int inforID, int checkRented)
        {
            ModifiedHistory modifiedHistory = new ModifiedHistory()
            {
                InforID = inforID,
                ModifiedTime = DateTime.Now,
                Content = (checkRented == 1) ? "Đang cho thuê" : "Trọ trống"
            };
            db.ModifierHistorys.Add(modifiedHistory);
            db.SaveChanges();
        }
        public List<ModifiedHistory> GetAllModifiedHistories(int InforID)
        {
            return db.ModifierHistorys.Where(history => history.InforID == InforID).ToList();
        }
        #endregion
    }
}

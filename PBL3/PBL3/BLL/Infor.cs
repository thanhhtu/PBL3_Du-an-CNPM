using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    public class Infor
    {
        private static DataPBL3 db;
        private static Infor _Instance;
        public static Infor Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Infor();
                return _Instance;
            }
            private set { }
        }
        private Infor()
        {
            db = new DataPBL3();
        }
        public void LoadApp()
        {
            //tác động lên db để thao tác ban đầu mượt hơn
            db.AccommodationInformations.Count();
        }
    }
}

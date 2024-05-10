using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class InforBLL
    {
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
    }
}

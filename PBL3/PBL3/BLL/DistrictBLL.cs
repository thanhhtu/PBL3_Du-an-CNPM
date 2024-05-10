using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class DistrictBLL
    {
<<<<<<< HEAD
        #region ->Singleton Pattern
=======
        #region -> Singleton Pattern
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        private static DataPBL3 db;
        private static DistrictBLL _Instance;
        public static DistrictBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DistrictBLL();
                return _Instance;
            }
            private set { }
        }
        private DistrictBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        public District GetDistrictByDistrictID(int inputDistrictID)
        {
            District result = new District();
<<<<<<< HEAD
            result = db.Districts.FirstOrDefault(p => p.DistrictID == inputDistrictID);
            return result;
        }
=======
            result = db.Districts.FirstOrDefault(p => p.DistrictID == inputDistrictID); //tham số truyền vào là 1 lamda method
            return result;
        }

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        public List<District> GetAllDistricts()
        {
            List<District> result = db.Districts.ToList();
            return result;
        }
<<<<<<< HEAD
=======

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        //Lấy ra tất cả các phường thuộc quận
        public List<Ward> GetWardsInDistrict(int inputDistrictID)
        {
            List<Ward> result = new List<Ward>();
            var district = db.Districts.FirstOrDefault(p => p.DistrictID == inputDistrictID);
            result = district.Wards.ToList();
            return result;
        }
    }
}

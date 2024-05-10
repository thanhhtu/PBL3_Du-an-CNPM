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
        #region ->Singleton Pattern
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
            result = db.Districts.FirstOrDefault(p => p.DistrictID == inputDistrictID);
            return result;
        }
        public List<District> GetAllDistricts()
        {
            List<District> result = db.Districts.ToList();
            return result;
        }
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

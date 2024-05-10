using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBL3.DTO.ViewDTO
{
    public class InforDTGViewDTO
    {
        //Class hiển thị thông tin quản lý post cho Admin
        public int InforID { get; set; }
        public int? UserID { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int NumberOfComment { get; set; }
        public bool BeingRented { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.ViewDTO
{
    public class InforViewDTO
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public int? UserID { get; set; }
        public int InforID { get; set; }
        public string Description { get; set; }
        public double SquareArea { get; set; }
        public double Deposit { get; set; }
        public double Price { get; set; }
        public List<string> ImagePaths { get; set; }
        public bool LivingWithOwner { get; set; }
    }
}

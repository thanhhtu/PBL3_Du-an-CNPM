using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Favorite_Infor")]
    public class Favorite_Infor
    {
        [Key, Column(Order = 0)]
        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("AccommodationInformationID")]
        public int InforID { get; set; }
        public virtual AccommodationInformation AccommodationInformation { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<AccommodationInformation> AccommodationInformations { get; set; }

        public Favorite_Infor()
        {
            this.Users = new HashSet<User>();
            this.AccommodationInformations = new HashSet<AccommodationInformation>();
        }
    }
}

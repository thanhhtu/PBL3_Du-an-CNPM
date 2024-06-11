using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("FavoriteInfor")]
    public class FavoriteInfor
    {
        [Key]
        [Required]
        public int FavoriteInforID { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [Required]
        public int InforID { get; set; }
        [ForeignKey("InforID")]
        public virtual AccommodationInformation AccommodationInformation { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<AccommodationInformation> AccommodationInformations { get; set; }

        public FavoriteInfor()
        {
            this.Users = new HashSet<User>();
            this.AccommodationInformations = new HashSet<AccommodationInformation>();
        }
    }
}

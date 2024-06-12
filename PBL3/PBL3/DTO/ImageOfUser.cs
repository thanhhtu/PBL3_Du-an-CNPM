using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("ImageOfUser")]
    public class ImageOfUser
    {
        [Key]
        [Required]
        public int ImageOfUserID { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}

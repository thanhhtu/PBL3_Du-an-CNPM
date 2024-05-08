using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Image")]
    public class Image
    {
        [Key]
        [Required]
        public int ImageID { get; set; }

        [Required]
        [StringLength(200)]
        public string ImagePath { get; set; }
        [Required]
        public int InforID { get; set; }

        [ForeignKey("InforID")]
        public virtual AccommodationInformation AccommodationInformation { get; set; }
    }
}

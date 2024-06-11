using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("ModifiedHistory")]
    public class ModifiedHistory
    {
        [Key]
        [Required]
        public int ModifiedID { get; set; }

        [Required]
        public int InforID { get; set; }
        [ForeignKey("InforID")]
        public virtual AccommodationInformation AccommodationInformation { get; set; }
           
        [Required]
        public DateTime ModifiedTime { get; set; }

        [Required]
        public string Content { get; set; }
    }
}


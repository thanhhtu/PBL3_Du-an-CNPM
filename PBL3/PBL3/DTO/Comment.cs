using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        [Required]
        public int CommentID { get; set; }

        [Required]
        public int InforID { get; set; }
        [ForeignKey("InforID")]
        public virtual AccommodationInformation AccommodationInformation { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}

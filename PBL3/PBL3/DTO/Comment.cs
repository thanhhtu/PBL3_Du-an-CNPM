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
        public int CommentID { get; set; }

        [ForeignKey("InforID")]
        public int InforID { get; set; }
        public virtual AccommodationInformation AccommodationInformation { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

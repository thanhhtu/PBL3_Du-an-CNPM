using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PBL3.DTO
{
    [Table("AccommodationInformation")]
    public class AccommodationInformation
    {
        [Key]
        [Required]
        public int InforID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

       
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double SquareArea { get; set; }

        [Required]
        public bool BeingRented { get; set; }

        [Required]
        public DateTime CreatedTime { get; set; }

        public DateTime? ModifiedTime { get; set; }

        public bool? LivingWithOwner { get; set; }

        public int? Deposit { get; set; }

        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public int? AddressID { get; set; }

        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    
        public virtual ICollection<Image> Images { get; set; }

        public AccommodationInformation()
        {
            this.Comments = new HashSet<Comment>();
            this.Images = new HashSet<Image>();
        }
    }
}

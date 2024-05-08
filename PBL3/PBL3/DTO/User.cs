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
    [Table("User")]
    public class User
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }


        [StringLength(20)]
        public string IDcard { get; set; }

       

        [Required]
        public int AddressID { get; set; }
        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        [Required]
        public int AccountID { get; set; }

        [ForeignKey("AccountID")]
        public virtual Account Account { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public User()
        {
            this.Comments = new HashSet<Comment>();
        }
    }
}

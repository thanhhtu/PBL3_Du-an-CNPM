using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    [Table("Ward")]
    public class Ward
    {
        [Key]
        [Required]
        public int WardID { get; set; }

        [Required]
        [StringLength(50)]
        public string WardName { get; set; }

        [Required]
        public int DistrictID { get; set; }

        [ForeignKey("DistrictID")]
        public virtual District District { get; set; }
 
        public virtual ICollection<Address> Addresses { get; set; }

        public Ward()
        {
            this.Addresses = new HashSet<Address>();
        }
    }
}

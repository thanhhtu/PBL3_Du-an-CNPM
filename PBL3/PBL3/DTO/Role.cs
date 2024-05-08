using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace PBL3.DTO
{
    [Table("Role")]
    public class Role
    {
        [Key]
        [Required]
        public int RoleID { get; set; }

        [Required]
        public string RoleName { get; set; }

        // đoạn dưới ni A có: để định nghĩa một mối quan hệ 1 - nhiều giữa 2 bảng role với accounts

        public virtual ICollection<Account> Accounts { get; set; }
        //tạo một đối tượng Role, thuộc tính Accounts sẽ được khởi tạo với một danh sách rỗng các tài khoản
        public Role()
        {
            this.Accounts = new HashSet<Account>();
        }

    }
}


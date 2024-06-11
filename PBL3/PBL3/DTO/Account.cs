﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace PBL3.DTO
{
    [Table("Account")]
    public class Account
    {
        [Key]
        [Required]
        public int AccountID { get; set; }

        [Required]
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Pwd { get; set; }

        [Required]
        public DateTime CreatedTime { get; set; }

        [Required]
        public bool BeingPublished { get; set; }

        public DateTime? PublishedTime { get; set; }

        [Required]
        public bool BeingPaused { get; set; }
    }
}

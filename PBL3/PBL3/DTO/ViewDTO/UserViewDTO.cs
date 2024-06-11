﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO.ViewDTO
{
    public class UserViewDTO
    {
        public int UserID { get; set; }
        public string Rolename { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int NumberOfInfor { get; set; }
        public int NumberOfComment { get; set; }
        public DateTime? JoinTime { get; set; }
        public String BeingPublished { get; set; }
        public DateTime? PublishedTime { get; set; }
        public String BeingPaused {  get; set; }
    }
}

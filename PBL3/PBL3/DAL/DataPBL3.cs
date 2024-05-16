using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Windows.Media;
using System.Xml.Linq;
using PBL3.DTO;
namespace PBL3.DAL
{
    public class DataPBL3 : DbContext //tạo bảng, relation ship với ánh xạ giữa các bảng
    {
        public DataPBL3()
            : base("DataPBL3")
        {
            Database.SetInitializer<DataPBL3>(new CreateDB());
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AccommodationInformation> AccommodationInformations { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ImageOfUser> ImageOfUsers { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<FavoriteInfor> FavoriteInfors { get; set; }
    }
}
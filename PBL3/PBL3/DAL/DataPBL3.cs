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
        // Your context has been configured to use a 'MyData' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DB_PBL3.MyData' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyData' 
        // connection string in the application configuration file.
        public DataPBL3()
            : base("Data Source=THANHTULAPTOP\\SQLEXPRESS;Initial Catalog=DataPBL3;Integrated Security=True")
        {
            Database.SetInitializer<DataPBL3>(new CreateDB());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
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
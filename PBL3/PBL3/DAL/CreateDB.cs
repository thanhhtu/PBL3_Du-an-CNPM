using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml.Linq;
using PBL3.DTO;

namespace PBL3.DAL
{
    public class CreateDB : DropCreateDatabaseAlways<DataPBL3>
    {
        protected override void Seed(DataPBL3 context)
        {
            context.Roles.AddRange(new Role[]
            {
                new Role {RoleID = 1, RoleName = "Admin"},
                new Role {RoleID = 2, RoleName = "Landlord"},
                new Role {RoleID = 3, RoleName = "Renter"}
            });
            context.Accounts.AddRange(new Account[]
            {
                new Account {AccountID = 1, RoleID = 1, Username = "Admin1", Pwd = "DeHOn0UsIwM=", CreatedAt = DateTime.Now, BeingPublished = true, PublishedAt = DateTime.Now},
                new Account {AccountID = 2, RoleID = 2, Username = "Landlord1", Pwd = "DeHOn0UsIwM=", CreatedAt = DateTime.Now, BeingPublished = true, PublishedAt = DateTime.Now},
                new Account {AccountID = 3, RoleID = 2, Username = "Landlord2", Pwd = "DeHOn0UsIwM=", CreatedAt = DateTime.Now, BeingPublished = false, PublishedAt = DateTime.Now},
                new Account {AccountID = 4, RoleID = 3, Username = "Renter1", Pwd = "DeHOn0UsIwM=", CreatedAt = DateTime.Now, BeingPublished = true, PublishedAt = DateTime.Now},
            });
            context.Districts.AddRange(new District[]
            {
                new District {DistrictID = 1, DistrictName = "Quận Hải Châu"},
                new District {DistrictID = 2, DistrictName = "Quận Cẩm Lệ"},
                new District {DistrictID = 3, DistrictName = "Quận Thanh Khê"},
                new District {DistrictID = 4, DistrictName = "Quận Liên Chiểu"},
                new District {DistrictID = 5, DistrictName = "Quận Ngũ Hành Sơn"},
                new District {DistrictID = 6, DistrictName = "Quận Sơn Trà"},
                new District {DistrictID = 7, DistrictName = "Huyện Hòa Vang"},
            });
            context.Wards.AddRange(new Ward[]
            {
                //huyện hòa vang
                new Ward {WardID = 1, WardName = "Xã Hòa Phong", DistrictID = 7},
                new Ward {WardID = 2, WardName = "Xã Hòa Bắc", DistrictID = 7},
                new Ward {WardID = 3, WardName = "Xã Hòa Châu", DistrictID = 7},
                new Ward {WardID = 4, WardName = "Xã Hòa Khương", DistrictID = 7},
                new Ward {WardID = 5, WardName = "Xã Hòa Liên", DistrictID = 7},
                new Ward {WardID = 6, WardName = "Xã Hòa Nhơn", DistrictID = 7},
                new Ward {WardID = 7, WardName = "Xã Hòa Ninh", DistrictID = 7},
                new Ward {WardID = 8, WardName = "Xã Hòa Phú", DistrictID = 7},
                new Ward {WardID = 9, WardName = "Xã Hòa Phước", DistrictID = 7},
                new Ward {WardID = 10, WardName = "Xã Hòa Sơn", DistrictID = 7},
                new Ward {WardID = 11, WardName = "Xã Hòa Tiến", DistrictID = 7},
                //quận hải châu
                new Ward {WardID = 12, WardName = "Phường Bình Hiên", DistrictID = 1},
                new Ward {WardID = 13, WardName = "Phường Bình Thuận", DistrictID = 1},
                new Ward {WardID = 14, WardName = "Phường Hải Châu I", DistrictID = 1},
                new Ward {WardID = 15, WardName = "Phường Hòa Châu II", DistrictID = 1},
                new Ward {WardID = 16, WardName = "Phường Hòa Cường Bắc", DistrictID = 1},
                new Ward {WardID = 17, WardName = "Phường Hòa Cường Nam", DistrictID = 1},
                new Ward {WardID = 18, WardName = "Phường Hòa Thuận Đồng", DistrictID = 1},
                new Ward {WardID = 19, WardName = "Phường Hòa Thuận Tây", DistrictID = 1},
                new Ward {WardID = 20, WardName = "Phường Nam Dương", DistrictID = 1},
                new Ward {WardID = 21, WardName = "Phường Phước Ninh", DistrictID = 1},
                new Ward {WardID = 22, WardName = "Phường Thạch Thang", DistrictID = 1},
                new Ward {WardID = 23, WardName = "Phường Thanh Bình", DistrictID = 1},
                new Ward {WardID = 24, WardName = "Phường Thuận Phước", DistrictID = 1},
                //quận cẩm lệ
                new Ward {WardID = 25, WardName = "Phường Hòa An", DistrictID = 2},
                new Ward {WardID = 26, WardName = "Phường Hòa Phát", DistrictID = 2},
                new Ward {WardID = 27, WardName = "Phường Hòa Thọ Đông", DistrictID = 2},
                new Ward {WardID = 28, WardName = "Phường Hòa Thọ Tây", DistrictID = 2},
                new Ward {WardID = 29, WardName = "Phường Hòa Xuân", DistrictID = 2},
                new Ward {WardID = 30, WardName = "Phường Khuê Trung", DistrictID = 2},
                 //quận thanh khê dis id = 3
                new Ward {WardID = 31, WardName = "Phường An Khê", DistrictID = 3},
                new Ward {WardID = 32, WardName = "Phường Chính Gián", DistrictID = 3},
                new Ward {WardID = 33, WardName = "Phường Hòa Khê", DistrictID = 3},
                new Ward {WardID = 34, WardName = "Phường Tam Thuận", DistrictID = 3},
                new Ward {WardID = 35, WardName = "Phường Tân Chính", DistrictID = 3},
                new Ward {WardID = 36, WardName = "Phường Thạc Gián", DistrictID = 3},
                new Ward {WardID = 37, WardName = "Phường Thanh Khê Đông", DistrictID = 3},
                new Ward {WardID = 38, WardName = "Phường Thanh Khê Tây", DistrictID = 3},
                new Ward {WardID = 39, WardName = "Phường Vĩnh Trung", DistrictID = 3},
                new Ward {WardID = 40, WardName = "Phường Xuân Hà", DistrictID = 3},
                //quận liên chiểu dis id = 4
                new Ward {WardID = 41, WardName = "Phường Hòa Hiệp Bắc", DistrictID = 4},
                new Ward {WardID = 42, WardName = "Phường Hòa Hiệp Nam", DistrictID = 4},
                new Ward {WardID = 43, WardName = "Phường Hòa Khánh Bắc", DistrictID = 4},
                new Ward {WardID = 44, WardName = "Phường Hòa Khánh Nam", DistrictID = 4},
                new Ward {WardID = 45, WardName = "Phường Hòa Minh", DistrictID = 4},       
                //quận ngũ hành sơn dis = 5
                new Ward {WardID = 46, WardName = "Phường Hòa Hải", DistrictID = 5},
                new Ward {WardID = 47, WardName = "Phường Hòa Quý", DistrictID = 5},
                new Ward {WardID = 48, WardName = "Phường Khuê Mỹ", DistrictID = 5},
                new Ward {WardID = 49, WardName = "Phường Mỹ An", DistrictID = 5},
                //quận sơn trà dis id = 6
                new Ward {WardID = 50, WardName = "Phường An Hải Bắc", DistrictID = 6},
                new Ward {WardID = 51, WardName = "Phường An Hải Đông", DistrictID = 6},
                new Ward {WardID = 52, WardName = "Phường An Hải Tây", DistrictID = 6},
                new Ward {WardID = 53, WardName = "Phường Mân Thái", DistrictID = 6},
                new Ward {WardID = 54, WardName = "Phường Nại Hiên Đông", DistrictID = 6},
                new Ward {WardID = 55, WardName = "Phường Phước Mỹ", DistrictID = 6},
                new Ward {WardID = 56, WardName = "Phường Thọ Quang", DistrictID = 6},
            });

            context.Addresses.AddRange(new Address[]
            {
                //address gán cho trọ
                new Address {AddressID = 1, WardID = 43, DetailAddress = "54 Nguyễn Lương Bằng"},
                new Address {AddressID = 2, WardID = 49, DetailAddress = "71 Ngũ Hành Sơn"},
                new Address {AddressID = 3, WardID = 44, DetailAddress = "459 Tôn Đức Thắng"},
                new Address {AddressID = 4, WardID = 37, DetailAddress = "478 Điện Biên Phủ"},
                new Address {AddressID = 5, WardID = 6, DetailAddress = "200 Trường Sơn"},
                new Address {AddressID = 6, WardID = 44, DetailAddress = "120 Hoàng Minh Thảo"},
                new Address {AddressID = 7, WardID = 36, DetailAddress = "254 Nguyễn Văn Linh"},
                new Address {AddressID = 8, WardID = 14, DetailAddress = "41 Lê Duẩn"},
                //address gán cho User
                new Address {AddressID = 9, WardID = 43, DetailAddress = "54 Nguyễn Lương Bằng"},
                new Address {AddressID = 10, WardID = 43, DetailAddress = "54 Nguyễn Lương Bằng"},
                new Address {AddressID = 11, WardID = 43, DetailAddress = "54 Nguyễn Lương Bằng"},
                new Address {AddressID = 12, WardID = 43, DetailAddress = "54 Nguyễn Lương Bằng"},
            });
            context.Users.AddRange(new User[]
            {
                new User {UserID = 1, FullName = "Hà Văn Khánh Đạt", Email ="hadatalex@gmail.com", AddressID = 9, Phone = "0123501235", AccountID = 1, IDcard = "123123123123"},
                new User {UserID = 2, FullName = "Võ Thanh Tú", Email ="tu@gmail.com", AddressID = 10, Phone = "0123123124", AccountID = 2, IDcard = "123123123123"},
                new User {UserID = 3, FullName = "Lê Nguyễn Ái Trân", Email ="tran@gmail.com", AddressID = 11, Phone = "0124124124", AccountID = 3, IDcard = "123123123123"},
                new User {UserID = 4, FullName = "Hoàng", Email ="hoang@gmail.com", AddressID = 12, Phone = "0789307893", AccountID = 4, IDcard = "123123123123"},
            });

            context.AccommodationInformations.AddRange(new AccommodationInformation[]
            {
                new AccommodationInformation {InforID = 1, UserID = 2, AddressID = 1, Title = "Cho thuê trọ gần Đại Học Bách Khoa", Description = "Trọ mới xây, an toàn, đẹp, mát mẻ",
                            Price = 1300000, SquareArea = 22.5, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 100
                },
                new AccommodationInformation {InforID = 2, UserID = 2, AddressID = 2, Title = "Cho thuê trọ tại ĐH KT ĐN", Description = "Trọ an toàn, đẹp",
                            Price = 2100000, SquareArea = 15, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 0
                },
                new AccommodationInformation {InforID = 3, UserID = 2, AddressID = 3, Title = "Cho thuê trọ gần ĐH SP DN", Description = "Trọ gần trường, an ninh, nhiều bạn nữ",
                            Price = 1200000, SquareArea = 23, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 0
                },
                new AccommodationInformation {InforID = 4, UserID = 2, AddressID = 4, Title = "Trọ gần Co.op Mart", Description = "Trọ gần Co.op mart, sạch sẽ, an ninh",
                            Price = 1500000, SquareArea = 20, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 400
                },
                new AccommodationInformation {InforID = 5, UserID = 3, AddressID = 5, Title = "Cho thuê trọ Hòa Nhơn, Hòa Vang", Description = "Trọ gần bệnh viện, trường học",
                            Price = 900000, SquareArea = 17.5, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 500
                },
                new AccommodationInformation {InforID = 6, UserID = 3, AddressID = 6, Title = "Trọ gần ĐH Duy Tân Hòa Khánh Nam", Description = "Trọ một bên trường, tiện cho việc đi lại",
                            Price = 1400000, SquareArea = 15.5, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 600
                },
                new AccommodationInformation {InforID = 7, UserID = 3, AddressID = 7, Title = "Trọ kiệt Nguyễn Văn Linh", Description = "Trọ ở trung tâm, đảm bảo an ninh trật tự",
                            Price = 700000, SquareArea = 10.5, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 200
                },
                new AccommodationInformation {InforID = 8, UserID = 3, AddressID = 8, Title = "Trọ cần cầu Sông Hàn", Description = "Trọ ở gần cầu sông Hàn, view đẹp",
                            Price = 1100000, SquareArea = 10.5, BeingRented = false,
                            CreatedTime = DateTime.Now, ModifiedTime = null,
                            LivingWithOwner = null, Deposit = 100
                }
            });
            context.Images.AddRange(new Image[] //1 bài Infor có đúng 3 ảnh
            {
                new Image { ImageID = 1, InforID = 1, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 2, InforID = 1, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 3, InforID = 1, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 4, InforID = 2, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 5, InforID = 2, ImagePath = @"\phongtro3.jpg"},
                new Image { ImageID = 6, InforID = 2, ImagePath = @"\phongtro1.jpg"},

                new Image { ImageID = 7, InforID = 3, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 8, InforID = 3, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 9, InforID = 3, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 10, InforID = 4, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 11, InforID = 4, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 12, InforID = 4, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 13, InforID = 5, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 14, InforID = 5, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 15, InforID = 5, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 16, InforID = 6, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 17, InforID = 6, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 18, InforID = 6, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 19, InforID = 7, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 20, InforID = 7, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 21, InforID = 7, ImagePath = @"\phongtro3.jpg"},

                new Image { ImageID = 22, InforID = 8, ImagePath = @"\phongtro1.jpg"},
                new Image { ImageID = 23, InforID = 8, ImagePath = @"\phongtro2.jpg"},
                new Image { ImageID = 24, InforID = 8, ImagePath = @"\phongtro3.jpg"},
            });
            context.Comments.AddRange(new Comment[]
            {
                new Comment {CommentID = 1, InforID = 1, UserID = 2, Content = "Haha", CreatedAt = DateTime.Now},
                new Comment {CommentID = 2, InforID = 1, UserID = 2, Content = "Hihi", CreatedAt = DateTime.Now},
                new Comment {CommentID = 3, InforID = 2, UserID = 3, Content = "Hehe", CreatedAt = DateTime.Now},
                new Comment {CommentID = 4, InforID = 2, UserID = 3, Content = "Huhu", CreatedAt = DateTime.Now},
                new Comment {CommentID = 5, InforID = 3, UserID = 1, Content = "Huhu", CreatedAt = DateTime.Now},
                new Comment {CommentID = 6, InforID = 3, UserID = 3, Content = "HicHic", CreatedAt = DateTime.Now},
            });
            context.FavoriteInfors.AddRange(new FavoriteInfor[]
            {
                new FavoriteInfor{ UserID = 2, InforID = 1},
                new FavoriteInfor{ UserID = 2, InforID = 2},
                new FavoriteInfor{ UserID = 2, InforID = 3},
                new FavoriteInfor{ UserID = 3, InforID = 4},
                new FavoriteInfor{ UserID = 3, InforID = 5},
                new FavoriteInfor{ UserID = 4, InforID = 6},
                new FavoriteInfor{ UserID = 4, InforID = 7},
                new FavoriteInfor{ UserID = 4, InforID = 8},
            });
            context.ImageOfUsers.AddRange(new ImageOfUser[]
            {
                new ImageOfUser { ImageOfUserID = 1, UserID = 2, ImagePath = @"landlord1.jpg"},
                new ImageOfUser { ImageOfUserID = 2, UserID = 2, ImagePath = @"landlord2.jpg"},

                new ImageOfUser { ImageOfUserID = 3, UserID = 3, ImagePath = @"landlord1.jpg"},
                new ImageOfUser { ImageOfUserID = 4, UserID = 3, ImagePath = @"landlord2.jpg"},
            });
        }
    }
}

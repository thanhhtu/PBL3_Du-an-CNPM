using PBL3.BLL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
using PBL3.Views.CommonForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Views;

namespace PBL3.Views.RenterForm
{
    public partial class UserInforForm : Form
    {
        //Phần này được sử dụng để hiển thị các bài info
        private int currentPage = 0; //Trang hiện tại
        private int totalPage; //Tổng số trang
        private int skipNum = 5; //1 lần chỉ có thể hiển thị 5 bài info
        private int postNum; //Tổng số bài info ở trong trang hiện tại
        private int numberOfPosts;
        public static int UserID;
        public UserInforForm(int userID)
        {
            InitializeComponent();
            InitializeInformation(userID);
            Display(userID);
            UserID = userID;
            LoadCBBPageNum();
        }
        private void InitializeInformation(int userID)
        {

            User user = UserBLL.Instance.GetUserByID(userID);
            labelFullname.Text += " " + user.FullName;
            labelPhone.Text += " " + user.Phone;
            labelEmail.Text += " " + user.Email;
            label3.Text = AddressBLL.Instance.GetFullAddress(user.AddressID);
        }
        private void DisablePostViewWhenNotFound(int postNum)
        {
            //Ẩn các house info component khi số post trên page đó ít hơn 5
            switch (postNum)
            {
                case 4:
                    houseInfoComponent5.Visible = false;
                    break;
                case 3:
                    houseInfoComponent5.Visible = false;
                    houseInfoComponent4.Visible = false;
                    break;
                case 2:
                    houseInfoComponent5.Visible = false;
                    houseInfoComponent4.Visible = false;
                    houseInfoComponent3.Visible = false;
                    break;
                case 1:
                    houseInfoComponent5.Visible = false;
                    houseInfoComponent4.Visible = false;
                    houseInfoComponent3.Visible = false;
                    houseInfoComponent2.Visible = false;
                    break;
                case 0:
                    houseInfoComponent5.Visible = false;
                    houseInfoComponent4.Visible = false;
                    houseInfoComponent3.Visible = false;
                    houseInfoComponent2.Visible = false;
                    houseInfoComponent1.Visible = false;
                    break;
            }
        }
        // hiển thị các customcomponenthouseinfor lên
        private void DisplayHouseInformation()
        {
            this.Visible = true;
            panel1.Visible = true;
            houseInfoComponent1.Visible = true;
            houseInfoComponent2.Visible = true;
            houseInfoComponent3.Visible = true;
            houseInfoComponent4.Visible = true;
            houseInfoComponent5.Visible = true;
        }

        private void InitalizeHouseInfomation(List<InforViewDTO> postView)
        {
            //Khởi tạo và hiển thị thông tin lên
            string imagePath;
            if (postView.Count > 0 && houseInfoComponent1.Visible)
            {
                houseInfoComponent1.DescLabel = "Miêu tả : " + postView[0].Description;
                houseInfoComponent1.AddressLabel = "Địa chỉ : " + postView[0].Address;
                houseInfoComponent1.HomeLink = postView[0].Title;
                houseInfoComponent1.MoneyLabel = "Số tiền : "
                    + postView[0].Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "/Tháng";
                houseInfoComponent1.AreaLabel = "Diện tích : " + postView[0].SquareArea + " m\u00b2";
                houseInfoComponent1.PostID = postView[0].InforID.ToString();
                imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(postView[0].InforID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[0].ImagePaths.Count > 0)
                {
                    System.Drawing.Image image1;
                    using (Stream stream = File.OpenRead(imagePath + postView[0].ImagePaths[0]))
                    {
                        image1 = System.Drawing.Image.FromStream(stream);
                    }
                    houseInfoComponent1.PictureBox = image1;
                }
            }
            if (postView.Count > 0 && houseInfoComponent2.Visible)
            {
                houseInfoComponent2.DescLabel = "Miêu tả : " + postView[1].Description;
                houseInfoComponent2.AddressLabel = "Địa chỉ : " + postView[1].Address;
                houseInfoComponent2.HomeLink = postView[1].Title;
                houseInfoComponent2.MoneyLabel = "Số tiền : "
                    + postView[1].Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "/Tháng";
                houseInfoComponent2.AreaLabel = "Diện tích : " + postView[1].SquareArea + " m\u00b2";
                houseInfoComponent2.PostID = postView[1].InforID.ToString();

                imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(postView[1].InforID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[1].ImagePaths.Count > 0)
                {
                    System.Drawing.Image image1;
                    using (Stream stream = File.OpenRead(imagePath + postView[1].ImagePaths[0]))
                    {
                        image1 = System.Drawing.Image.FromStream(stream);
                    }
                    houseInfoComponent2.PictureBox = image1;
                }
            }
            if (postView.Count > 2 && houseInfoComponent3.Visible)
            {
                houseInfoComponent3.DescLabel = "Miêu tả : " + postView[2].Description;
                houseInfoComponent3.AddressLabel = "Địa chỉ : " + postView[2].Address;
                houseInfoComponent3.HomeLink = postView[2].Title;
                houseInfoComponent3.MoneyLabel = "Số tiền : "
                    + postView[2].Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "/Tháng";
                houseInfoComponent3.AreaLabel = "Diện tích : " + postView[2].SquareArea + " m\u00b2";
                houseInfoComponent3.PostID = postView[2].InforID.ToString();

                imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(postView[2].InforID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[2].ImagePaths.Count > 0)
                {
                    System.Drawing.Image image1;
                    using (Stream stream = File.OpenRead(imagePath + postView[2].ImagePaths[0]))
                    {
                        image1 = System.Drawing.Image.FromStream(stream);
                    }
                    houseInfoComponent3.PictureBox = image1;
                }
            }
            if (postView.Count > 3 && houseInfoComponent4.Visible)
            {
                houseInfoComponent4.DescLabel = "Miêu tả : " + postView[3].Description;
                houseInfoComponent4.AddressLabel = "Địa chỉ : " + postView[3].Address;
                houseInfoComponent4.HomeLink = postView[3].Title;
                houseInfoComponent4.MoneyLabel = "Số tiền : "
                    + postView[3].Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "/Tháng";
                houseInfoComponent4.AreaLabel = "Diện tích : " + postView[3].SquareArea + " m\u00b2";
                houseInfoComponent4.PostID = postView[3].InforID.ToString();

                imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(postView[3].InforID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[3].ImagePaths.Count > 0)
                {
                    System.Drawing.Image image1;
                    using (Stream stream = File.OpenRead(imagePath + postView[3].ImagePaths[0]))
                    {
                        image1 = System.Drawing.Image.FromStream(stream);
                    }
                    houseInfoComponent4.PictureBox = image1;
                }
            }
            if (postView.Count > 4 && houseInfoComponent5.Visible)
            {
                houseInfoComponent5.DescLabel = "Miêu tả : " + postView[4].Description;
                houseInfoComponent5.AddressLabel = "Địa chỉ : " + postView[4].Address;
                houseInfoComponent5.HomeLink = postView[4].Title;
                houseInfoComponent5.MoneyLabel = "Số tiền : "
                    + postView[4].Price.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "/Tháng";
                houseInfoComponent5.AreaLabel = "Diện tích : " + postView[4].SquareArea + " m\u00b2";
                houseInfoComponent5.PostID = postView[4].InforID.ToString();

                imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(postView[4].InforID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[4].ImagePaths.Count > 0)
                {
                    System.Drawing.Image image1;
                    using (Stream stream = File.OpenRead(imagePath + postView[4].ImagePaths[0]))
                    {
                        image1 = System.Drawing.Image.FromStream(stream);
                    }
                    houseInfoComponent5.PictureBox = image1;
                }
            }
        }
        private void Display(int userID)
        {   //tổng số bài
            numberOfPosts = FavoriteInforBLL.Instance.GetFavoriteCount(userID);
            // tổng số bài trong trang hiện tại
            postNum = (numberOfPosts - currentPage * 5 < 5) ? numberOfPosts - currentPage * 5 : 5;
            totalPage = (int)Math.Ceiling(numberOfPosts / Convert.ToDouble(skipNum));
            DisplayHouseInformation();
            List<InforViewDTO> inforFavourite = FavoriteInforBLL.Instance.GetFavoriteInfor(currentPage * skipNum, postNum, userID);
            DisablePostViewWhenNotFound(postNum);
            InitalizeHouseInfomation(inforFavourite);
        }

        private void customInforComponent3__OnLabelClicked(object sender, EventArgs e)
        {

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            currentPage = currentPage - 1;
            if (currentPage < 0)
                currentPage = 0;
            Display(UserID);
            LoadCBBPageNum();

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int a = FavoriteInforBLL.Instance.GetFavoriteCount(UserID);
            if (a == 0) { MessageBox.Show("Bạn đã xem hết các bài đăng!"); }
            else
            {
                currentPage = currentPage + 1;
                if (currentPage == totalPage)
                {
                    currentPage = totalPage - 1;
                    MessageBox.Show("Bạn đã xem hết các bài đăng!");
                }
                LoadCBBPageNum();
                Display(UserID);
            }


        }
        public void LoadCBBPageNum()
        {
            cbbPageNumber.Items.Clear();
            cbbPageNumber.DataSource = null;
            cbbPageNumber.ResetText();
            int i;
            //ở mỗi trang thêm 1 cbb, nếu trang hiện tại được hiển thị thì đó là mục trong cbbPageNumber đc chọn
            for (i = 0; i < totalPage; i++)
            {
                CBBItem temp = new CBBItem
                {
                    Value = i,
                    Text = "Trang " + (i + 1).ToString()
                };
                cbbPageNumber.Items.Add(temp);
                if (temp.Value == currentPage)
                {
                    cbbPageNumber.SelectedItem = temp;
                }
            }
        }
        private void cbbPageNumber_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            currentPage = ((CBBItem)cbbPageNumber.SelectedItem).Value;
            if (currentPage < 0)
                currentPage = totalPage - 1;
            Display(UserID);
        }



        private void DeleteFavorite2(object sender, EventArgs e)
        {
            FavoriteInforBLL.Instance.DeleteFavourite_Infor(LoginInfor.UserID, Convert.ToInt32(houseInfoComponent2.PostID));
            Display(UserID);
        }

        private void DeleteFavorite3(object sender, EventArgs e)
        {
            FavoriteInforBLL.Instance.DeleteFavourite_Infor(LoginInfor.UserID, Convert.ToInt32(houseInfoComponent3.PostID));
            Display(UserID);
        }

        private void DeleteFavorite4(object sender, EventArgs e)
        {
            FavoriteInforBLL.Instance.DeleteFavourite_Infor(LoginInfor.UserID, Convert.ToInt32(houseInfoComponent4.PostID));
            Display(UserID);
        }

        private void DeleteFavorite5(object sender, EventArgs e)
        {
            FavoriteInforBLL.Instance.DeleteFavourite_Infor(LoginInfor.UserID, Convert.ToInt32(houseInfoComponent5.PostID));
            Display(UserID);
        }

        private void DeleteFavorite1(object sender, EventArgs e)
        {
            FavoriteInforBLL.Instance.DeleteFavourite_Infor(LoginInfor.UserID, Convert.ToInt32(houseInfoComponent1.PostID));
            Display(UserID);
        }

        public delegate void showPostDetail(Form childForm);
        public showPostDetail showInfo;
        public void ReOpen()
        {
            this.Show();
        }

        private void houseInfoComponent1__OnLabelClicked(object sender, EventArgs e)
        {
            if (houseInfoComponent1 != null)
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent1.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

        private void houseInfoComponent2__OnLabelClicked(object sender, EventArgs e)
        {
            if (houseInfoComponent2 != null)
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent2.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

        private void houseInfoComponent3__OnLabelClicked(object sender, EventArgs e)
        {
            if (houseInfoComponent3 != null)
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent3.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

        private void houseInfoComponent4__OnLabelClicked(object sender, EventArgs e)
        {
            if (houseInfoComponent4 != null)
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent4.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

        private void houseInfoComponent5__OnLabelClicked(object sender, EventArgs e)
        {
            if (houseInfoComponent4 != null)
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent5.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

    }
}

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
using PBL3.BLL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
using PBL3.Views.CustomComponents;
//using PBL3.DTO.ViewDTO;

namespace PBL3.Views.CommonForm
{
    public partial class DashboardForm : Form
    {
        // sort (cbbPageNumber, cbb Sort sẽ được ưu tiên hơn nút tìm kiếm)
        // lưu trữ trang thái, = true thì đang ở trạng thái đó (searching/sorting)
        private bool searching = false;
        private bool sorting = false;

        //Phần này được sử dụng để hiển thị các bài info
        private int currentPage = 0; //Trang hiện tại
        private int totalPage; //Tổng số trang
        private int skipNum = 5; //1 lần chỉ có thể hiển thị 5 bài info
        private int postNum; //Tổng số bài info ở trong trang hiện tại
        private int numberOfPosts;

        public DashboardForm()
        {
            InitializeComponent();
            InforBLL.Instance.LoadApp();
            LoadCBB();
            SearchFunction();
            LoadCBBPageNum();
            HideAdd_DeleteFavouriteInfor();
        }
        #region-> LoadCBB quận + phường
        // Mặc định: Load quận trước (phường: hiện tất cả
        // Khi selected item của cbb quận thay đổi thì load phường tương ứng với quận
        public void ResetCBB()
        {
            cbbDistrict.Items.Clear(); // xoa cac item hien co trong cbb
            cbbDistrict.DataSource = null; // xoa toan bo du lieu dang ket noi voi cbb
            cbbWard.Items.Clear();
            cbbWard.DataSource = null;
        }
        public void LoadCBB()
        {
            ResetCBB();
            cbbSort.SelectedIndex = -1;
            cbbArea.SelectedIndex = -1;
            cbbArea.SelectedIndex = -1;

            //CBB Item được định nghĩa ở DTO
            CBBItem AllDistricts = new CBBItem
            {
                Value = 0,
                Text = "Tất cả quận"
            };
            CBBItem AllWards = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };

            //load quận lên cbb

            cbbDistrict.Items.Add(AllDistricts);
            var listDistrict = DistrictBLL.Instance.GetAllDistricts();

            foreach (var i in listDistrict)
            {
                cbbDistrict.Items.Add(new CBBItem
                {
                    Value = i.DistrictID,
                    Text = i.DistrictName.ToString()
                });
            }
            // mặc định là hiện "tất cả quận"
            cbbDistrict.SelectedItem = AllDistricts;
            //load và set cbb phường
            cbbWard.Items.Add(AllWards);
            cbbWard.SelectedItem = AllWards;
        }
        private void cbbDistrict_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            if (((CBBItem)cbbDistrict.SelectedItem).Value == 0)
            {
                LoadCBB();
            }
            else
            {
                CBBItem AllWards = new CBBItem
                {
                    Value = 0,
                    Text = "Tất cả phường"
                };
                int districtID = ((CBBItem)cbbDistrict.SelectedItem).Value;
                //load phuong
                cbbWard.Items.Clear();
                cbbWard.Items.Add(AllWards);
                var WardInDistrict = DistrictBLL.Instance.GetWardsInDistrict(districtID);
                foreach (var i in WardInDistrict)
                {
                    cbbWard.Items.Add(new CBBItem
                    {
                        Value = i.WardID,
                        Text = i.WardName
                    });
                }
                cbbWard.SelectedItem = AllWards;
            }
        }
        #endregion

        #region Load CBB số trang
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
            //Sorting được ưu tiên nhất
            if (sorting)
            {
                 SortFunction();
                return;
            }
            SearchFunction();
        }

        #endregion
        #region ->Load Dashboard
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
            panel2.Visible = true;
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



        #endregion

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            currentPage = currentPage - 1;
            if (currentPage < 0)
                currentPage = 0;
            LoadCBBPageNum();
            if (sorting)
            {
                SortFunction();
                return;
            }
            SearchFunction();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage = currentPage + 1;
            if (currentPage == totalPage)
            {
                currentPage = totalPage - 1;
                MessageBox.Show("Bạn đã xem hết các bài đăng!");
            }
            LoadCBBPageNum();

            if (sorting)
            {
                SortFunction();
                return;
            }
            SearchFunction();
        }
        public List<AccommodationInformation> GetSearchPost()
        {
            //Search post theo giá trị các cbb địa chỉ, giá, diện tích
            //Mặc định giá trị trái là 0, phải là rất lớn
            int lPrice = 0, rPrice = 999999999;
            float lArea = 0, rArea = 999999999;
            int priceChoice = cbbPrice.SelectedIndex;
            int areaChoice = cbbArea.SelectedIndex;
            //Set left right cho giá
            switch (priceChoice)
            {
                case 0:
                    lPrice = 0;
                    rPrice = 999999999;
                    break;
                case 1:
                    lPrice = 0;
                    rPrice = 1000000;
                    break;
                case 2:
                    lPrice = 1000000;
                    rPrice = 1500000;
                    break;
                case 3:
                    lPrice = 1500000;
                    rPrice = 2000000;
                    break;
                case 4:
                    lPrice = 2000000;
                    rPrice = 999999999;
                    break;
                default:
                    lPrice = 0;
                    rPrice = 999999999;
                    break;
            }
            //Set left right cho diện tích
            switch (areaChoice)
            {
                case 0:
                    lArea = 0;
                    rArea = 999999999;
                    break;
                case 1:
                    lArea = 0;
                    rArea = 20;
                    break;
                case 2:
                    lArea = 20;
                    rArea = 25;
                    break;
                case 3:
                    lArea = 25;
                    rArea = 30;
                    break;
                case 4:
                    lArea = 30;
                    rArea = 999999999;
                    break;
                default:
                    lArea = 0;
                    rArea = 999999999;
                    break;
            }
            int searchCase = 0, searchID = 0;
            int districtID = ((CBBItem)cbbDistrict.SelectedItem).Value;
            int wardID = ((CBBItem)cbbWard.SelectedItem).Value;
            if (districtID == 0)
            {
                //Case 1: District ID == 0 <=> search trong toàn thành phố
                searchCase = 1;
                searchID = 0;
            }
            else if (wardID == 0)
            {
                //Case 2: District ID != 0 và ward ID == 0  <=> search trong quận
                searchCase = 2;
                searchID = districtID;
            }
            else
            {
                //Case 3: ward ID != 0  <=> search trong phường
                searchCase = 3;
                searchID = wardID;
            }
            if (!searching) searchCase = 100; //không phải đang search nên cho search case rơi vào default
            return InforBLL.Instance.SearchInfor(searchCase, searchID, lPrice, rPrice, lArea, rArea);
        }
        private void SortFunction()
        {
            //Lấy dữ liệu hiện tại
            int sortCase = cbbSort.SelectedIndex;
            var allSearchData = GetSearchPost();
            //Sort và hiển thị
            numberOfPosts = allSearchData.Count();
            postNum = (numberOfPosts - currentPage * 5 < 5) ? numberOfPosts - currentPage * 5 : 5;
            totalPage = (int)Math.Ceiling(numberOfPosts / Convert.ToDouble(skipNum));
            DisplayHouseInformation();
            List<InforViewDTO> postView = InforBLL.Instance.GetSortedPosts(currentPage * skipNum, postNum, allSearchData, sortCase);
            DisablePostViewWhenNotFound(postNum);
            InitalizeHouseInfomation(postView);
        }
        private void SearchFunction()
        {
            //Lấy kết quả search
            var allSearchData = GetSearchPost();
            //Lấy và hiển thị search data
            numberOfPosts = allSearchData.Count();
            postNum = (numberOfPosts - currentPage * 5 < 5) ? numberOfPosts - currentPage * 5 : 5;
            totalPage = (int)Math.Ceiling(numberOfPosts / Convert.ToDouble(skipNum));
            DisplayHouseInformation();
            List<InforViewDTO> postView = InforBLL.Instance.GetSearchedInfor(currentPage * skipNum, postNum, allSearchData);
            DisablePostViewWhenNotFound(postNum);
            InitalizeHouseInfomation(postView);
        }
        private void cbbPrice_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 0;
            searching = true;
            SearchFunction();
            LoadCBBPageNum();
        }

        private void cbbSort_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            currentPage = 0;
            sorting = true;
            SortFunction();
            LoadCBBPageNum();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCBB();
            LoadCBBPageNum();
            searching = false;
            sorting = false;
            SearchFunction();
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
                if (LoginInfor.UserID == -1)
                {
                    //Chưa đăng nhập => ẩn cmt và rating
                    InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent1.PostID), true);
                    form.goback = ReOpen;
                    showInfo(form);
                }
                else
                {
                    InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent1.PostID));
                    //InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent1.PostID), true);
                    form.goback = ReOpen;
                    showInfo(form);
                }
            }
        }

        private void houseInfoComponent2__OnLabelClicked(object sender, EventArgs e)
        {
            if (LoginInfor.UserID == -1)
            {
                //Chưa đăng nhập => ẩn cmt và rating
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent2.PostID), true);
                form.goback = ReOpen;
                showInfo(form);
            }
            else
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent2.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

        private void houseInfoComponent3__OnLabelClicked(object sender, EventArgs e)
        {
            if (LoginInfor.UserID == -1)
            {
                //Chưa đăng nhập => ẩn cmt và rating
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent3.PostID), true);
                form.goback = ReOpen;
                showInfo(form);
            }
            else
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent3.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

        private void houseInfoComponent4__OnLabelClicked(object sender, EventArgs e)
        {
            if (LoginInfor.UserID == -1)
            {
                //Chưa đăng nhập => ẩn cmt và rating
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent4.PostID), true);
                form.goback = ReOpen;
                showInfo(form);
            }
            else
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent4.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }

        private void houseInfoComponent5__OnLabelClicked(object sender, EventArgs e)
        {
            if (LoginInfor.UserID == -1)
            {
                //Chưa đăng nhập => ẩn cmt và rating
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent5.PostID), true);
                form.goback = ReOpen;
                showInfo(form);
            }
            else
            {
                InforForm form = new InforForm(Convert.ToInt32(houseInfoComponent5.PostID));
                form.goback = ReOpen;
                showInfo(form);
            }
        }
        // ẩn các trái tim // aitran
        private void HideAdd_DeleteFavouriteInfor()
        {
            houseInfoComponent1.HideUtilityPanel();
            houseInfoComponent2.HideUtilityPanel();
            houseInfoComponent3.HideUtilityPanel();
            houseInfoComponent4.HideUtilityPanel();
            houseInfoComponent5.HideUtilityPanel();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;

namespace PBL3.Views.LandlordForm
{
    public partial class UpdateInforForm : Form
    {
        private int InforID;
        private List<string> ImagePathList;
        private List<string> imageFileName;
        public UpdateInforForm(int inforID)
        {
            InitializeComponent();

            LoadCBB();
            InforID = inforID;
            ImagePathList = new List<string>();
            imageFileName = new List<string>();
            InitializeInfor();
        }

        #region -> Load and set CBB
        public void ResetCBB()
        {
            cbbDistrict.Items.Clear();
            cbbDistrict.DataSource = null;
            cbbDistrict.ResetText();

            cbbWard.Items.Clear();
            cbbWard.DataSource = null;
            cbbWard.ResetText();
        }

        public void LoadCBB()
        {
            ResetCBB();

            CBBItem AllDistrict = new CBBItem
            {
                Value = -1,
                Text = "Tất cả quận"
            };
            cbbDistrict.Items.Add(AllDistrict);
            cbbDistrict.SelectedItem = AllDistrict;

            //Hiện tất cả các quận lên cbbDistrict
            var listDistrict = DistrictBLL.Instance.GetAllDistricts();
            foreach (var i in listDistrict)
            {
                cbbDistrict.Items.Add(new CBBItem
                {
                    Value = i.DistrictID,
                    Text = i.DistrictName.ToString()
                });
            }

            CBBItem AllWard = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };
            cbbWard.Items.Add(AllWard);
            cbbWard.SelectedItem = AllWard;
        }

        //Nếu người dùng chọn "Tất cả quận" -> phường chỉ hiển thị "Tất cả phường"
        //Nếu người dùng chọn quận cụ thể -> hiện tất cả phường thuộc quận đó
        private void cbbDistrict_OnSelectionChangedCommited(object sender, EventArgs e)
        {

            if (((CBBItem)cbbDistrict.SelectedItem).Value == 0)
            {
                LoadCBB();
            }
            else
            {
                CBBItem AllWard = new CBBItem
                {
                    Value = 0,
                    Text = "Tất cả phường"
                };

                cbbWard.Items.Clear();
                cbbWard.Items.Add(AllWard);

                int districtID = ((CBBItem)cbbDistrict.SelectedItem).Value;

                //Hiện tất cả các phường thuộc 1 quận
                var WardInDistrict = DistrictBLL.Instance.GetWardsInDistrict(districtID);
                foreach (var i in WardInDistrict)
                {
                    cbbWard.Items.Add(new CBBItem
                    {
                        Value = i.WardID,
                        Text = i.WardName
                    });
                }
                cbbWard.SelectedItem = AllWard;
            }
        }

        //Set CBB
        public void InitializeCBB()
        {
            int addressID = (int)InforBLL.Instance.GetAddressIDByPostID(InforID);
            int districtID = AddressBLL.Instance.GetDistrictIDByAddressID(addressID);
            int wardID = AddressBLL.Instance.GetWardIDByAddressID(addressID);

            //Set cbbDistrict
            foreach (var i in cbbDistrict.Items)
            {
                if (((CBBItem)i).Value == districtID)
                {
                    cbbDistrict.SelectedItem = i;
                    break;
                }
            }

            //Xổ ra hết các phường thuộc quận (đã chọn quận sẵn)
            CBBItem AllWard = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };
            cbbWard.Items.Clear();
            cbbWard.Items.Add(AllWard);
            var WardInDistrict = DistrictBLL.Instance.GetWardsInDistrict(districtID);
            foreach (var i in WardInDistrict)
            {
                cbbWard.Items.Add(new CBBItem
                {
                    Value = i.WardID,
                    Text = i.WardName
                });
            }

            //Set chọn quận
            foreach (var i in cbbWard.Items)
            {
                if (((CBBItem)i).Value == wardID)
                {
                    cbbWard.SelectedItem = i;
                    break;
                }
            }
        }
        #endregion

        #region -> Validate
        public bool CheckEmpty()
        {
            if (cbbWard.SelectedIndex == 0 || txtDetailAddress.Texts == "" || txtTitle.Texts == "" || txtPrice.Texts == "" || txtArea.Texts == "" || !radioBtnLiveWithOwner.Checked && !radioBtnNotLiveWithOwner.Checked)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }

        //Kiểm tra số tiền có phải số dương không
        public bool CheckValidPrice()
        {
            double x;
            bool check = double.TryParse(txtPrice.Texts, out x);
            if (!check)
            {
                MessageBox.Show("Vui lòng nhập giá tiền là một số nguyên!");
                return true;
            }
            if (x <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá tiền là một số nguyên dương!");
                return true;
            }
            return false;
        }

        //Kiểm tra số tiền cọc có phải số dương không
        public bool CheckValidDeposit()
        {
            double x;
            bool check = double.TryParse(txtDeposit.Texts, out x);
            if (!check)
            {
                MessageBox.Show("Vui lòng nhập tiền cọc là một số nguyên!");
                return true;
            }
            if (x <= 0)
            {
                MessageBox.Show("Vui lòng nhập tiền cọc là một số nguyên dương!");
                return true;
            }
            return false;
        }

        //Kiểm tra số tiền có phải số dương không
        public bool CheckValidArea()
        {
            double x;
            bool check = double.TryParse(txtArea.Texts, out x);
            if (!check)
            {
                MessageBox.Show("Vui lòng nhập diện tích là một số!");
                return true;
            }
            if (x <= 0)
            {
                MessageBox.Show("Vui lòng nhập diện tích là một số dương!");
                return true;
            }
            return false;
        }
        #endregion

        #region -> Click components
        //Thay đổi ảnh
        private void btnUpdateImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Chọn ba ảnh!";
            opFile.Multiselect = true;
            opFile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (opFile.FileNames.Length != 3)
                    {
                        MessageBox.Show("Bạn phải chọn 3 ảnh!");
                        opFile.Dispose();
                        return;
                    }
                    else if (opFile.FileNames.Distinct().Count() != opFile.FileNames.Length)
                    {
                        MessageBox.Show("Tên file ảnh phải khác nhau!");
                        opFile.Dispose();
                    }
                    IEnumerable<string> imagesIterator = opFile.FileNames.Take(3);
                    string[] images = imagesIterator.ToArray();
                    pictureBox1.Image = System.Drawing.Image.FromFile(images[0]);
                    pictureBox2.Image = System.Drawing.Image.FromFile(images[1]);
                    pictureBox3.Image = System.Drawing.Image.FromFile(images[2]);
                    for (int i = 0; i < 3; i++)
                    {
                        ImagePathList.Add(images[i]);
                        imageFileName.Add(opFile.SafeFileNames[i]);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Lỗi không thể mở file: " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void btnUpdateInfor_Click(object sender, EventArgs e)
        {
            //Validation
            if (CheckEmpty()) return;
            if (CheckValidPrice()) return;
            if (CheckValidArea()) return;
            if (CheckValidDeposit()) return;

            Address tempAddress = new Address
            {
                DetailAddress = txtDetailAddress.Texts,
                WardID = ((CBBItem)cbbWard.SelectedItem).Value
            };

            string description = txtDetailAddress.Texts;
            int deposit = Convert.ToInt32(txtDeposit.Texts);

            //Cập nhật infor
            AccommodationInformation editedInfor = new AccommodationInformation()
            {
                InforID = this.InforID,
                UserID = LoginInfor.UserID,
                Title = txtTitle.Texts,
                Price = Convert.ToDouble(txtPrice.Texts),
                SquareArea = Convert.ToDouble(txtArea.Texts),
                Description = description,
                Deposit = deposit,
                LivingWithOwner = radioBtnLiveWithOwner.Checked,
                BeingRented = radioBtnRented.Checked,
                ModifiedTime = DateTime.Now
            };
            InforBLL.Instance.UpdateInfor(editedInfor);

            string imagePathStorage = ImageBLL.Instance.GetImageStoragePathsOfPost(InforID);
            if (ImagePathList.Count != 0)
            {
                ImageBLL.Instance.DeleteImageFromFolder(imagePathStorage);
                ImageBLL.Instance.DeleteImageFromPost(InforID);

                if (!Directory.Exists(imagePathStorage)) Directory.CreateDirectory(imagePathStorage);
                for (int i = 0; i < 3; i++)
                {
                    File.Copy(ImagePathList[i], imagePathStorage + @"\" + imageFileName[i]);
                    ImageBLL.Instance.AddImage(@"\" + imageFileName[i], InforID);
                }
            }

            MessageBox.Show("Thông tin đã được cập nhật!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //Khởi tạo thông tin trọ thông qua bài thông tin
        private void InitializeInfor()
        {
            InforViewDTO inforView = InforBLL.Instance.GetInforByID(InforID);
            txtTitle.Texts = inforView.Title;
            txtDetailAddress.Texts = AddressBLL.Instance.GetDetailAddress(InforBLL.Instance.GetAddressIDByPostID(InforID));
            txtPrice.Texts = inforView.Price.ToString();
            txtArea.Texts = inforView.SquareArea.ToString();
            txtDescribe.Texts = inforView.Description;

            if (InforBLL.Instance.CheckRented(InforID) == "Đã thuê") radioBtnRented.Checked = true;
            else radioBtnNotRented.Checked = true;
            
            txtDeposit.Texts = inforView.Deposit.ToString();
            radioBtnLiveWithOwner.Checked = InforBLL.Instance.CheckLivingwOwwer(InforID);
            radioBtnNotLiveWithOwner.Checked = !InforBLL.Instance.CheckLivingwOwwer(InforID);
            InitializeImage(inforView);
            InitializeCBB();
        }

        //Khởi tạo img
        private void InitializeImage(InforViewDTO post)
        {
            try
            {
                string imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(InforID);
                System.Drawing.Image image1;
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[0]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                }
                pictureBox1.Image = image1;
                System.Drawing.Image image2;
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[1]))
                {
                    image2 = System.Drawing.Image.FromStream(stream);
                }
                pictureBox2.Image = image2;

                System.Drawing.Image image3;
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[2]))
                {
                    image3 = System.Drawing.Image.FromStream(stream);
                }
                pictureBox3.Image = image3;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
        }
    }
}

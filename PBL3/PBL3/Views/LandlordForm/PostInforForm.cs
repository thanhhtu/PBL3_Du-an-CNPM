using PBL3.BLL;
using PBL3.DTO;
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

namespace PBL3.Views.LandlordForm
{
    public partial class PostInforForm : Form
    {
        private List<string> imagePathList;
        private List<string> imageFileName;

        public PostInforForm()
        {
            InitializeComponent();

            LoadCBB();
            imagePathList = new List<string>();
            imageFileName = new List<string>();
        }

        #region -> Load CBB
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
                Value = 0,
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

        public bool CheckFailImage()
        {
            if (imagePathList.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ảnh!");
                return true;
            }
            return false;
        }

        //Kiểm tra số tiền có phải số dương không
        public bool CheckValidMoney(string price, string deposit)
        {
            double x, y;
            bool checkPrice = double.TryParse(price, out x);
            bool checkDeposit = double.TryParse(deposit, out y);
            if (!checkPrice || !checkDeposit)
            {
                MessageBox.Show("Vui lòng nhập giá tiền (tiền thuê và tiền đặt cọc) là một số nguyên!");
                return true;
            }
            if (x <= 0 || y < 0)
            {
                MessageBox.Show("Vui lòng nhập giá tiền (tiền thuê và tiền đặt cọc) là một số nguyên dương!");
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

        #region -> Click Button
        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Vui lòng chọn 3 ảnh";
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
                        imagePathList.Add(images[i]);
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

        private void btnPostInfor_Click(object sender, EventArgs e)
        {
            //Validation
            if (CheckEmpty()) return;
            if (CheckFailImage()) return;
            if (CheckValidMoney(txtPrice.Texts, txtDeposit.Texts)) return;
            if (CheckValidArea()) return;

            //Thêm address
            Address temp = new Address
            {
                DetailAddress = txtDetailAddress.Texts,
                WardID = ((CBBItem)cbbWard.SelectedItem).Value
            };
            int addressID = AddressBLL.Instance.AddAddress(temp);

            string description = txtDetailAddress.Texts;
            double deposit = Convert.ToDouble(txtDeposit.Texts);

            //Thêm infor
            AccommodationInformation infor = new AccommodationInformation()
            {
                UserID = LoginInfor.UserID,
                AddressID = addressID,
                Title = txtTitle.Texts,
                Price = Convert.ToDouble(txtPrice.Texts),
                SquareArea = Convert.ToDouble(txtArea.Texts),
                Description = description,
                Deposit = deposit,
                LivingWithOwner = radioBtnLiveWithOwner.Checked,
                BeingRented = false,
                CreatedTime = DateTime.Now
            };
            int inforID = InforBLL.Instance.AddInfor(infor);

            //Thêm img
            string imagePathStorage = ImageBLL.Instance.GetImageStoragePathsOfPost(inforID);
            if (!Directory.Exists(imagePathStorage)) Directory.CreateDirectory(imagePathStorage);
            for (int i = 0; i < 3; i++)
            {
                File.Copy(imagePathList[i], imagePathStorage + @"\" + imageFileName[i]);
                ImageBLL.Instance.AddImage(@"\" + imageFileName[i], inforID);
            }

            MessageBox.Show("Thông tin trọ của bạn đã được tải lên hệ thống!!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

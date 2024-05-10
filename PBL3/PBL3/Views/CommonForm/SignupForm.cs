using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;
using System.Net.Mail;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace PBL3.Views.CommonForm
{
    public partial class SignUpForm : Form
    {
        private List<string> imagePathList;
        private List<string> imageFileName;

        public SignUpForm()
        {
            InitializeComponent();
            LoadCBB();
            imagePathList = new List<string>();
            imageFileName = new List<string>();
        }

        #region -> Load CBB
        public void ResetCBB()
<<<<<<< HEAD
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

        #region -> Validation
        //Kiểm tra xem mật khẩu nhập lại có chính xác không
        public bool checkFailRetypePassword()
        {
            if (txtPwd.Texts != txtConfirmPwd.Texts)
            {
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại!");
                return true;
            };
            return false;
        }

        //Kiểm tra username tồn tại hay chưa
        public bool checkExistUsername()
        {
            if (AccountBLL.Instance.CheckExistingUsername(txtUserName.Texts))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác!");
                return true;
            }
            return false;
        }

        //Kiểm tra xem có ô nào còn bỏ trống không và đã chọn phường chưa (chọn quận mới được chọn phường nên chỉ check phường)
        public bool checkEmpty()
        {
            if (txtFullName.Texts == "" || txtEmail.Texts == "" || txtPhone.Texts == "" ||
                txtPwd.Texts == "" || txtConfirmPwd.Texts == "" || txtDetailAddress.Texts == "" ||
                (radioBtnRenter.Checked == false && radioBtnLandlord.Checked == false) || cbbWard.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }

        //Kiểm tra xem địa chỉ email có hợp lệ hay không (user@domain)
        public bool checkIsValidEmailAddress(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress); //MailAddress là 1 class trong .NET
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng địa chỉ email user@domain");
                return false;
            }
        }

        //Kiểm tra số điện thoại có hợp lệ không (sđt có 10 chữ số, không chứa chữ)
        public bool CheckPhoneNumber(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$")) //Regex là một công cụ để so khớp 
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!");
                return false;
            }
            return true;
        }

        //Kiểm tra số CCCD có hợp lệ không (10 chữ số, không chứa chữ)
        public bool CheckCCCD(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\d{12}$")) //Regex là một công cụ để so khớp 
            {
                MessageBox.Show("Số CCCD có 12 chữ số!");
                return false;
            }
            return true;
        }

        //Kiểm tra đã có ảnh chưa
        public bool CheckFailImage()
        {
            if (imagePathList.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh!");
                return true;
            }
            return false;
        }
        #endregion

        #region -> Show/Hide Password
        private void btnHidePwd_Click(object sender, EventArgs e)
=======
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        {
            cbbDistrict.Items.Clear();
            cbbDistrict.DataSource = null;
            cbbDistrict.ResetText();

            cbbWard.Items.Clear();
            cbbWard.DataSource = null;
            cbbWard.ResetText();
        }

<<<<<<< HEAD
        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == false)
            {
                btnHidePwd.BringToFront();
                txtPwd.PasswordChar = true;
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == true)
            {
                btnShowPwd.BringToFront();
                txtPwd.PasswordChar = false;
            }
        }

        private void btnShowConfirmPwd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPwd.PasswordChar == false)
            {
                btnHideConfirmPwd.BringToFront();
                txtConfirmPwd.PasswordChar = true;
            }
        }

        private void btnHideConfirmPwd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPwd.PasswordChar == true)
            {
                btnShowConfirmPwd.BringToFront();
                txtConfirmPwd.PasswordChar = false;
            }
        }
        #endregion

        public delegate void openlinklabel();
        public openlinklabel OpenForm;

        private void LabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForm();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn 2 ảnh";
            openFile.Multiselect = true;
            openFile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFile.FileNames.Length != 2)
                    {
                        MessageBox.Show("Bạn phải chọn 2 ảnh mặt trước và mặt sau!");
                        openFile.Dispose();
                        return;
                    }
                    else if (openFile.FileNames.Distinct().Count() != openFile.FileNames.Length)
                    {
                        MessageBox.Show("Tên file ảnh phải khác nhau!");
                        openFile.Dispose();
                    }

=======
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

        #region -> Validation
        //Kiểm tra xem mật khẩu nhập lại có chính xác không
        public bool checkFailRetypePassword()
        {
            if (txtPwd.Texts != txtConfirmPwd.Texts)
            {
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại!");
                return true;
            };
            return false;
        }

        //Kiểm tra username tồn tại hay chưa
        public bool checkExistUsername()
        {
            if (AccountBLL.Instance.CheckExistingUsername(txtUserName.Texts))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác!");
                return true;
            }
            return false;
        }

        //Kiểm tra xem có ô nào còn bỏ trống không và đã chọn phường chưa (chọn quận mới được chọn phường nên chỉ check phường)
        public bool checkEmpty()
        {
            if (txtFullName.Texts == "" || txtEmail.Texts == "" || txtPhone.Texts == "" ||
                txtPwd.Texts == "" || txtConfirmPwd.Texts == "" || txtDetailAddress.Texts == "" ||
                (radioBtnRenter.Checked == false && radioBtnLandlord.Checked == false) || cbbWard.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }

        //Kiểm tra xem địa chỉ email có hợp lệ hay không (user@domain)
        public bool checkIsValidEmailAddress(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress); //MailAddress là 1 class trong .NET
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng địa chỉ email user@domain");
                return false;
            }
        }

        //Kiểm tra số điện thoại có hợp lệ không (sđt có 10 chữ số, không chứa chữ)
        public bool CheckPhoneNumber(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$")) //Regex là một công cụ để so khớp 
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!");
                return false;
            }
            return true;
        }

        //Kiểm tra số CCCD có hợp lệ không (10 chữ số, không chứa chữ)
        public bool CheckCCCD(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\d{12}$")) //Regex là một công cụ để so khớp 
            {
                MessageBox.Show("Số CCCD có 12 chữ số!");
                return false;
            }
            return true;
        }

        //Kiểm tra đã có ảnh chưa
        public bool CheckFailImage()
        {
            if (imagePathList.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh!");
                return true;
            }
            return false;
        }
        #endregion

        #region -> Show/Hide Password
        private void btnHidePwd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == false)
            {
                btnHidePwd.BringToFront();
                txtPwd.PasswordChar = true;
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == true)
            {
                btnShowPwd.BringToFront();
                txtPwd.PasswordChar = false;
            }
        }

        private void btnShowConfirmPwd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPwd.PasswordChar == false)
            {
                btnHideConfirmPwd.BringToFront();
                txtConfirmPwd.PasswordChar = true;
            }
        }

        private void btnHideConfirmPwd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPwd.PasswordChar == true)
            {
                btnShowConfirmPwd.BringToFront();
                txtConfirmPwd.PasswordChar = false;
            }
        }
        #endregion

        public delegate void openlinklabel();
        public openlinklabel OpenForm;

        private void LabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenForm();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn 2 ảnh";
            openFile.Multiselect = true;
            openFile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFile.FileNames.Length != 2)
                    {
                        MessageBox.Show("Bạn phải chọn 2 ảnh mặt trước và mặt sau!");
                        openFile.Dispose();
                        return;
                    }
                    else if (openFile.FileNames.Distinct().Count() != openFile.FileNames.Length)
                    {
                        MessageBox.Show("Tên file ảnh phải khác nhau!");
                        openFile.Dispose();
                    }

>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
                    IEnumerable<string> imagesIterator = openFile.FileNames.Take(3);
                    string[] images = imagesIterator.ToArray();
                    pictureBox1.Image = System.Drawing.Image.FromFile(images[0]);
                    pictureBox2.Image = System.Drawing.Image.FromFile(images[1]);

                    for (int i = 0; i < 2; i++)
                    {
                        imagePathList.Add(images[i]);
                        imageFileName.Add(openFile.SafeFileNames[i]);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Lỗi không thể mở file " + exp.Message);
                }
            }
            else
            {
                openFile.Dispose();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Validation
            if (checkEmpty()) return;
            if (checkExistUsername()) return;
            if (checkFailRetypePassword()) return;
            if (!checkIsValidEmailAddress(txtEmail.Texts)) return;
            if (!CheckPhoneNumber(txtPhone.Texts)) return;

            if (radioBtnLandlord.Checked == true)
            {
                if (!CheckCCCD(txtCCCD.Texts)) return;
                if (CheckFailImage()) return;
            }
            else
            {

            }

            //Thêm tài khoản
            int roleID = radioBtnLandlord.Checked ? 2 : 3;

            int accID = AccountBLL.Instance.AddAccount(new Account
            {
                Username = txtUserName.Texts,
                Pwd = PwdHashing.EncodePwdToBase64(txtPwd.Texts),
                RoleID = roleID,
                CreatedAt = DateTime.Now,
                BeingPublished = false
            });

            //Thêm địa chỉ
            int addressID = AddressBLL.Instance.AddAddress(new Address
            {
                DetailAddress = txtDetailAddress.Texts,
                WardID = ((CBBItem)cbbWard.SelectedItem).Value
            });

            string cccd = "00000";
<<<<<<< HEAD
            if (radioBtnLandlord.Checked == true)
=======
            if(radioBtnLandlord.Checked == true)
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
            {
                cccd = txtCCCD.Texts;
            }

            //Thêm người dùng
            int userID = UserBLL.Instance.AddUser(new User
            {
                FullName = txtFullName.Texts,
                Phone = txtPhone.Texts,
                Email = txtEmail.Texts,
                AccountID = accID,
                AddressID = addressID,
                IDcard = cccd
            });

            //Thêm img
            if (radioBtnLandlord.Checked == true)
            {
                string imagePathStorage = ImageOfUserBLL.Instance.GetImageOfUserStoragePathsOfPost(userID);
                if (!Directory.Exists(imagePathStorage))
                {
                    Directory.CreateDirectory(imagePathStorage);
                }

                for (int i = 0; i < 2; i++)
                {
                    File.Copy(imagePathList[i], imagePathStorage + @"\" + imageFileName[i]);
                    ImageOfUserBLL.Instance.AddImageOfUser(@"\" + imageFileName[i], userID);
                }
            }

<<<<<<< HEAD
            if (radioBtnLandlord.Checked == true)
=======
            if(radioBtnLandlord.Checked == true)
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
            {
                MessageBox.Show("Đăng ký thành công! Admin sẽ xét duyệt tài khoản chủ trọ của bạn trong thời gian sớm nhất!");
            }
            else
            {
                MessageBox.Show("Đăng ký thành công!");
            }
            this.Close();
        }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnRenter.Checked == true)
            {
                btnAddImg.Enabled = false;
                btnAddImg.BackColor = Color.Gray;
                btnAddImg.BackgroundColor = Color.Gray;
                txtCCCD.Enabled = false;
            }
            else
            {
                btnAddImg.Enabled = true;
                btnAddImg.BackColor = Color.LightSkyBlue;
                btnAddImg.BackgroundColor = Color.LightSkyBlue;
                txtCCCD.Enabled = true;
            }
        }
    }
}

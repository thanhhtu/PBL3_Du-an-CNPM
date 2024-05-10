using PBL3.DTO;
using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Views.CommonForm
{
    public partial class UpdateUserForm : Form
    {

        public delegate void MyDel();
        public MyDel ReloadInformation;
        public UpdateUserForm()
        {
            InitializeComponent();
            LoadCBB();
            LoadUserInformation();
        }

        #region ->Load CBB
        public void ResetCBB()
        {
            cbbDistrict.Items.Clear();
            cbbDistrict.DataSource = null;
            cbbDistrict.ResetText();

            cbbDistrict.Items.Clear();
            cbbDistrict.DataSource = null;
            cbbDistrict.ResetText();
        }
        public void LoadCBB()
        {
            ResetCBB();
            CBBItem AllDistrict = new CBBItem
            {
                Value = 0,
                Text = "Tất cả quận"
            };
            CBBItem AllWard = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };
            cbbDistrict.Items.Add(AllDistrict);
            var listDistrict = DistrictBLL.Instance.GetAllDistricts();

            foreach (var i in listDistrict)
            {
                cbbDistrict.Items.Add(new CBBItem
                {
                    Value = i.DistrictID,
                    Text = i.DistrictName.ToString()
                });
            }
            cbbDistrict.SelectedItem = AllDistrict;
            cbbWard.Items.Add(AllWard);
            cbbWard.SelectedItem = AllWard;
        }

        #endregion

        public void SetCBB()
        {
            //Khởi tạo giá trị ban đầu cho CBB tương ứng với dữ liệu của user trên database
            int addressID = UserBLL.Instance.GetAddressIDByUserID(LoginInfor.UserID);
            int districtID = AddressBLL.Instance.GetDistrictIDByAddressID(addressID);
            int wardID = AddressBLL.Instance.GetWardIDByAddressID(addressID);
            //Set selected item của quận cbb tương ứng với dữ liệu của người dùng
            foreach (var i in cbbDistrict.Items)
            {
                if (((CBBItem)i).Value == districtID)
                {
                    cbbDistrict.SelectedItem = i;
                    break;
                }
            }
            CBBItem AllWard = new CBBItem
            {
                Value = 0,
                Text = "Tất cả phường"
            };
            cbbWard.Items.Clear();
            cbbWard.Items.Add(AllWard);
            //Lấy các phường trong quận để load cbb tương ứng
            var WardInDistrict = DistrictBLL.Instance.GetWardsInDistrict(districtID);
            foreach (var i in WardInDistrict)
            {
                cbbWard.Items.Add(new CBBItem
                {
                    Value = i.WardID,
                    Text = i.WardName
                });
            }
            //Set selected item của phường tương ứng với dữ liệu của user trên db
            foreach (var i in cbbWard.Items)
            {
                if (((CBBItem)i).Value == wardID)
                {
                    cbbWard.SelectedItem = i;
                    break;
                }
            }
        }
        private void LoadUserInformation()
        {
            //Set thông tin ban đầu tương ứng với dữ liệu của người dùng trên db
            User thisUser = UserBLL.Instance.GetUserByID(2);
            txtFullName.Texts = thisUser.FullName;
            txtEmail.Texts = thisUser.Email;
            txtNumber.Texts = thisUser.Phone;
            txtDetailedAddress.Texts = AddressBLL.Instance.GetDetailAddress(thisUser.AddressID);
            SetCBB();
        }
        private bool checkEmpty()
        {
            //Check thông tin đầy đủ chưa
            if (txtFullName.Texts == "" || txtEmail.Texts == "" || txtNumber.Texts == "" || cbbWard.SelectedIndex == 0 
                || txtDetailedAddress.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin!");
                return true;
            }
            return false;
        }
        private bool checkIsValidEmailAddress(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng địa chỉ email!");
                return false;
            }
        }
        public bool CheckPhoneNumber(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Bạn phải nhập số điện thoại có 10 chữ số!");
                return false;
            }
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validate thông tin có empty không
            if (checkEmpty()) return;
            if (!checkIsValidEmailAddress(txtEmail.Texts)) return;
            if (!CheckPhoneNumber(txtNumber.Texts)) return;
            User userInfo = new User
            {
                UserID = LoginInfor.UserID,
                FullName = txtFullName.Texts,
                Phone = txtNumber.Texts,
                Email = txtEmail.Texts,
            };
            Address addInfo = new Address
            {
                DetailAddress = txtDetailedAddress.Texts,
                WardID = ((CBBItem)cbbWard.SelectedItem).Value
            };
            UserBLL.Instance.UpdateUserInformation(userInfo, addInfo);
            MessageBox.Show("Thay đổi thông tin thành công!");
            ReloadInformation();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                int districtID = ((CBBItem)cbbDistrict.SelectedItem).Value;
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
                cbbWard.SelectedItem = AllWard;
            }
        }
    }
}

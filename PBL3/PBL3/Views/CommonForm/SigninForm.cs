using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
using PBL3.Views.AdminForm;
using PBL3.Views.LandlordForm;
using PBL3.Views.RenterForm;

namespace PBL3.Views.CommonForm
{
    public partial class SignInForm : Form
    {
        public delegate void MyDel();
        public MyDel hideParentForm;
        public MyDel closeParentForm;

        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Texts;
            string password = txtPwd.Texts;

            int role = AccountBLL.Instance.GetRole(username, password);
            if (role == 0)
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
                return;
            }

            //Nếu là chủ trọ kiểm tra có được duyệt tài khoản chưa
            if (AccountBLL.Instance.IsAcceptedLandlord(AccountBLL.Instance.GetAccountID(username, password)) == false)
            {
                MessageBox.Show("Tài khoản của bạn chưa được Admin duyệt. Xin vui lòng thử lại sau!");
                return;
            }

            //Kiểm tra xem tài khoản có bị ngừng hoạt động không
            if (AccountBLL.Instance.IsAcceptedAccount(AccountBLL.Instance.GetAccountID(username, password)) == false)
            {
                MessageBox.Show("Tài khoản của bạn đã bị ngừng hoạt động!");
                return;
            }

            //Gán thông tin người dùng cho SignInInforBLL để tạo phiên làm việc với user
            LoginInfor.UserID = UserBLL.Instance.GetUserIDByAccountID(AccountBLL.Instance.GetAccountID(username, password));

            //Thông tin nhập đúng thì sẽ dựa trên role của người dùng sẽ mở form tương ứng
            hideParentForm();
            if (role == 1)
            {
                AdminHomeForm form = new AdminHomeForm();
                form.ShowDialog();
            }
            else if (role == 2)
            {
                LandlordHomeForm form = new LandlordHomeForm();
                form.ShowDialog();
            }
            else if (role == 3)
            {
                RenterHomeForm form = new RenterHomeForm();
                form.ShowDialog();
            }
            closeParentForm();
        }

        #region -> Show/Hide Password
        private void btnHidePwd_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == true)
            {
                btnShowPwd.BringToFront();
                txtPwd.PasswordChar = false;
            }
        }

        private void btnShowPwd_Click(object sender, EventArgs e)
        {
            if (txtPwd.PasswordChar == false)
            {
                btnHidePwd.BringToFront();
                txtPwd.PasswordChar = true;
            }
        }
        #endregion

        public delegate void openlinklabel();
        public openlinklabel openForm;
        private void LabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openForm();
        }
    }
}

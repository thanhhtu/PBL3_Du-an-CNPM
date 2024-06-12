using PBL3.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Views.CommonForm
{
    public partial class ChangePwdForm : Form
    {

        public ChangePwdForm()
        {
            InitializeComponent();
        }

        #region -> Validate
        //Kiểm tra pass cũ và confirm giống nhau chưa
        private bool ValidatePassword()
        {
            if (txtNewPass.Texts != txtConfirmPass.Texts) return false;
            return true;
        }

        //Kiểm tra các thông tin đã đầy đủ chưa
        public bool CheckEmpty()
        {
            if (txtOldPass.Texts == "" || txtNewPass.Texts == "" || txtConfirmPass.Texts == "") return true;
            return false;
        }
        #endregion

        #region -> Click Button + Show/Hide Password   
        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin!");
                return;
            }
            if (!ValidatePassword())
                MessageBox.Show("Mật khẩu xác nhận không chính xác!");
            else
            {
                int userID = LoginInfor.UserID;
                if (AccountBLL.Instance.CheckPassword(UserBLL.Instance.GetAccountIDByUserID(userID), txtOldPass.Texts))
                {
                    AccountBLL.Instance.ChangePassword(UserBLL.Instance.GetAccountIDByUserID(userID), txtNewPass.Texts);
                    MessageBox.Show("Đã thay đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowOldPwd_Click(object sender, EventArgs e)
        {
            if (txtOldPass.PasswordChar == false)
            {
                btnHideOldPass.BringToFront();
                txtOldPass.PasswordChar = true;
            }
        }

        private void btnHideOldPass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.PasswordChar == true)
            {
                btnShowOldPwd.BringToFront();
                txtOldPass.PasswordChar = false;
            }
        }

        private void btnShowNewPwd_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == false)
            {
                btnHideNewPwd.BringToFront();
                txtNewPass.PasswordChar = true;
            }
        }

        private void btnHideNewPwd_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == true)
            {
                btnShowNewPwd.BringToFront();
                txtNewPass.PasswordChar = false;
            }
        }

        private void btnShowConfirmPwd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == false)
            {
                btnHideConfirmPwd.BringToFront();
                txtConfirmPass.PasswordChar = true;
            }
        }

        private void btnHideConfirmPwd_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.PasswordChar == true)
            {
                btnShowConfirmPwd.BringToFront();
                txtConfirmPass.PasswordChar = false;
            }
        }
        #endregion
    }
}

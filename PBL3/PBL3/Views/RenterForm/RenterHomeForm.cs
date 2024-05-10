using PBL3.Views.CommonForm;
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
using PBL3.Views.CommonForm;

namespace PBL3.Views.RenterForm
{
    public partial class RenterHomeForm : Form
    {
        //Form hiện tại đang được hiển thị trên childPanel
        private Form activeForm = null;

        public RenterHomeForm()
        {
            InitializeComponent();
            ReloadUserFullName();
            panelUserSubmenu.Visible = false; //Ban đầu không hiện chi tiết menu con
        }

        private void ReloadUserFullName()
        {
<<<<<<< HEAD
            labelUserFullname.Text = UserBLL.Instance.GetUserFullname(LoginInfor.UserID).ToString();
=======
            labelUserFullname.Text = UserBLL.Instance.GetUserFullname(SignInInfor.UserID).ToString();
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        }

        //Tắt form hiện tại đang hiển thị trên childPanel và hiển thị form tương ứng được truyền vào là đối số
        public void OpenChildForm(Form form)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = form;

            //set properties cho form truyền vào
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();

            form.Show();
        }

        public void OpenHouseInfo(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void HideSubmenu()
        {
            if (panelUserSubmenu.Visible)
            {
                panelUserSubmenu.Visible = false;
            }
        }

        //Đóng mở Submenu
        private void toggleSubmenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubmenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        #region -> Click Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            DashboardForm form = new DashboardForm();
<<<<<<< HEAD
            form.showInfo = OpenHouseInfo;
=======
            form.showPost = OpenHouseInfo;
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
            OpenChildForm(form);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelUserSubmenu);
        }

        private void btnId_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            OpenChildForm(new UserForm(LoginInfor.UserID));
=======
            OpenChildForm(new UserForm(SignInInfor.UserID));
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
        }

        private void btnUserChange_Click(object sender, EventArgs e)
        {
            UpdateUserForm form = new UpdateUserForm();
            form.ReloadInformation = ReloadUserFullName;
            OpenChildForm(form);
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePwdForm());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            //Reset lại SignInInfor
<<<<<<< HEAD
            LoginInfor.UserID = -1;
=======
            SignInInfor.UserID = -1;
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3

            //Hiển thị lại HomeForm
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();
        }
<<<<<<< HEAD
        #endregion
=======
       #endregion
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
    }
}

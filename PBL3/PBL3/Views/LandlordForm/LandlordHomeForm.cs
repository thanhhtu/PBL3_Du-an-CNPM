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
using PBL3.Views.LandlordForm;

namespace PBL3.Views.LandlordForm
{
    public partial class LandlordHomeForm : Form
    {
        //Form hiện tại đang được hiển thị trên childPanel
        private Form activeForm = null;

        public LandlordHomeForm()
        {
            InitializeComponent();
            ReloadUserFullName();
            panelUserSubmenu.Visible = false; //Ban đầu không hiện chi tiết menu con
        }

        //thêm nhóe
        private void SignOut()
        {
            //Reset lại SignInInfor
            LoginInfor.UserID = -1;

            //Hiển thị lại HomeForm
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();
        }
        //thêm nhóe

        #region -> Load form & show submenu
        private void ReloadUserFullName()
        {
            labelUserFullname.Text = UserBLL.Instance.GetUserFullname(LoginInfor.UserID).ToString();
        }

        //Tắt form hiện tại đang hiển thị trên childPanel và hiển thị form tương ứng được truyền vào là đối số
        public void OpenChildForm(Form form)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = form;

            //Set properties cho form truyền vào
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
        #endregion

        #region -> Click Components
        private void btnHome_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            DashboardForm form = new DashboardForm();
            form.showInfo = OpenHouseInfo;
            OpenChildForm(form);
        }

        private void btnInforManagement_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            LandlordForm.InforManagementForm form = new LandlordForm.InforManagementForm();
            OpenChildForm(form);
            form.showPost = OpenHouseInfo;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelUserSubmenu);
        }

        private void btnId_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserForm(LoginInfor.UserID));
        }

        private void btnUserChange_Click(object sender, EventArgs e)
        {
            UpdateUserForm form = new UpdateUserForm();
            form.ReloadInformation = ReloadUserFullName;
            form.closeHome = SignOut; //thêm nè
            OpenChildForm(form);
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePwdForm());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            SignOut();
        }
        #endregion
    }
}

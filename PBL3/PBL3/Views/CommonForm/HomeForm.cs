using PBL3.BLL;
using PBL3.Views.AdminForm;
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
    public partial class HomeForm : Form
    {
        //Form hiện tại đang được hiển thị trên childPanel
        private Form activeForm = null;

        public HomeForm()
        {
            InitializeComponent();

            InforBLL.Instance.LoadApp();
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

        public void OpenSignIn()
        {
            SignInForm form = new SignInForm();
            form.openForm = OpenSignUp;
            form.hideParentForm = HideHomeForm;
            form.closeParentForm = CloseHomeForm;
            OpenChildForm(form);
        }

        public void OpenSignUp()
        {
            SignUpForm form = new SignUpForm();
            form.OpenForm = OpenSignIn;
            OpenChildForm(form);
        }

        #region -> Click Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.showInfo = OpenHouseInfo;
            OpenChildForm(form);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignInForm form = new SignInForm();
            form.openForm = OpenSignUp;
            form.hideParentForm = HideHomeForm;
            form.closeParentForm = CloseHomeForm;
            OpenChildForm(form);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.OpenForm = OpenSignIn;
            OpenChildForm(form);
        }
        #endregion

        //CloseHomeForm và HideHomeForm được truyền là delegate cho SignInForm để nó sử dụng khi người dùng đăng nhập thành công
        private void CloseHomeForm()
        {
            this.Close();
        }
        private void HideHomeForm()
        {
            this.Hide();
        }
    }
}

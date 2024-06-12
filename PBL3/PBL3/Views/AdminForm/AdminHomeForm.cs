﻿using System;
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

namespace PBL3.Views.AdminForm
{
    public partial class AdminHomeForm : Form
    {
        //Form hiện tại đang được hiển thị trên childPanel
        private Form activeForm = null;

        public AdminHomeForm()
        {
            InitializeComponent();
            ReloadUserFullName();
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
            if (activeForm != null) activeForm.Hide();

            activeForm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void ReloadUserFullName()
        {
            labelUserFullname.Text = UserBLL.Instance.GetUserFullname(LoginInfor.UserID).ToString();
        }

        #region -> Click Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm();
            form.showInfo = OpenHouseInfo;
            OpenChildForm(form);
        }

        private void btnInforManagement_Click(object sender, EventArgs e)
        {
            InforManagementForm form = new InforManagementForm();
            OpenChildForm(form);
            form.showInfor = OpenHouseInfo;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserManagementForm());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            //Reset lại SignInInfor
            LoginInfor.UserID = -1;

            //Hiển thị lại HomeForm
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();
        }
        #endregion
    }
}

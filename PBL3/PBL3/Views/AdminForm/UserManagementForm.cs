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
using System.Windows.Controls;
using System.Windows.Forms;
using PBL3.Views.CommonForm;
namespace PBL3.Views.AdminForm
{
    public partial class UserManagementForm : Form
    {
        private static bool checkAscending = true;
        public UserManagementForm()
        {
            InitializeComponent();
            cbbUserRole.SelectedIndex = 0;
            cbbSort.SelectedIndex = 0;
            ShowDTG();
        }
        public void LoadHeader()
        {
            //Load các tên cột
            var headername = new List<string>()
            {   "STT",
                "User ID",
                "Loại tài khoản",
                "Họ và tên",
                "Email",
                "Điện thoại",
                "Địa chỉ",
                "Số phòng trọ",
                "Số bình luận",
                "Thời gian tạo tài khoản",
                "Trạng thái duyệt",
                "Thời gian duyệt"
                
            };
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = headername[i];
            }

        }
        // đạt sửa
        public void ShowDTG()
        {
            string searchChars = txtSearch.Texts;
            int sortCase = cbbSort.SelectedIndex;
            bool? published = true;
            string rolename = "All";
            if (cbbUserRole.SelectedIndex == 1) rolename = "Người cho thuê";
            if (cbbUserRole.SelectedIndex == 2)
            {
                rolename = "Người cho thuê";
                published = false;
            }
            if (cbbUserRole.SelectedIndex == 3) rolename = "Người đi thuê";
            dgv.DataSource = UserBLL.Instance.SearchUser(searchChars, rolename, sortCase, checkAscending, published);
            LoadHeader();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDTG();
        }
        private void AcceptHost_Click(object sender, EventArgs e)
        { // Duyệt chủ trọ  
            int userID = Convert.ToInt32(dgv.SelectedRows[0].Cells["UserID"].Value.ToString());
            DialogResult result = MessageBox.Show("Duyệt chủ trọ này ?",
    "Xác nhận",
    MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UserBLL.Instance.published(userID);
                MessageBox.Show("Duyệt thành công!");
                ShowDTG();

            }
            else
                return;
        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 tài khoản cần xoá!");
                return;
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xoá một lần 1 tài khoản");
                return;
            }
            int userID = Convert.ToInt32(dgv.SelectedRows[0].Cells["UserID"].Value.ToString());

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá người dùng này không ?",
                "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                UserBLL.Instance.DeleteUser(userID);
                MessageBox.Show("Xoá thành công!");
                ShowDTG();

            }
            else
                return;
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            //Xem thông tin người dùng
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 người dùng!");
                return;
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xem thông tin mỗi lần 1 người dùng!");
                return;
            }
            int userID = Convert.ToInt32(dgv.SelectedRows[0].Cells["UserID"].Value.ToString());
            UserForm form = new UserForm(userID);
            form.Visible = false;
            form.ShowDialog();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            checkAscending = !checkAscending;
            ShowDTG();
        }

        private void cbbSort_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            checkAscending = true;
            ShowDTG();
        }

        private void cbbUserRole_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSort.SelectedIndex = 0;
            checkAscending = true;
            ShowDTG();
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}

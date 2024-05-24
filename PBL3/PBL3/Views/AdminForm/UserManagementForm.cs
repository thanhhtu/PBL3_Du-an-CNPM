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
using PBL3.BLL;
using PBL3.DTO;
using PBL3.Views.CommonForm;
using PBL3.Views.LandlordForm;

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

        //Load các tên cột
        public void LoadHeader()
        {
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
                "Thời gian duyệt",
                "Tình trạng tài khoản"
            };
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = headername[i];
            }
            dgv.Columns["UserID"].Visible = false;
        }

        //tt sửa
        public void ShowDTG()
        {
            string searchChars = txtSearch.Texts;
            int sortCase = cbbSort.SelectedIndex;

            int userRole = cbbUserRole.SelectedIndex; //tt thêm
            bool? beingPublished = true;
            bool beingPaused = false; //tt thêm
            
            dgv.DataSource = UserBLL.Instance.SearchUser(searchChars, userRole, sortCase, checkAscending, beingPublished, beingPaused);
            LoadHeader();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDTG();
        }
        //tt đổi

        //Duyệt chủ trọ
        private void AcceptLandlord_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgv.SelectedRows[0].Cells["UserID"].Value.ToString());
            if (!UserBLL.Instance.IsPublishedAccount(userID))
            {
                DialogResult result = MessageBox.Show("Duyệt chủ trọ này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UserBLL.Instance.PublishUser(userID);
                    MessageBox.Show("Duyệt thành công!");
                    ShowDTG();
                }
                else return;
            }
            else
            {
                MessageBox.Show("Người dùng này đã được duyệt!");
            }
        }

        //Thay đổi từ delete sang pause
        private void btnPauseUser_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 tài khoản cần ngừng hoạt động!");
                return;
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được ngừng hoạt động mỗi lần 1 tài khoản");
                return;
            }
            int userID = Convert.ToInt32(dgv.SelectedRows[0].Cells["UserID"].Value.ToString());

            if (!UserBLL.Instance.IsPausedAccount(userID))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn ngừng hoạt động người dùng này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UserBLL.Instance.PauseUser(userID);
                    MessageBox.Show("Đã ngừng hoạt động tài khoản!");
                    ShowDTG();
                }
                else return;
            }
            else
            {
                MessageBox.Show("Người dùng này đã bị ngừng hoạt động!");
            }
        }

        //tt thêm
        private void btnActiveUser_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 tài khoản!");
                return;
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được cho phép hoạt động trở lại mỗi lần 1 tài khoản");
                return;
            }
            int userID = Convert.ToInt32(dgv.SelectedRows[0].Cells["UserID"].Value.ToString());

            if (UserBLL.Instance.IsPausedAccount(userID))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cho phép người dùng này hoạt động trở lại không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    UserBLL.Instance.ActiveUser(userID);
                    MessageBox.Show("Tài khoản hoạt động!");
                    ShowDTG();
                }
                else return;
            }
            else
            {
                MessageBox.Show("Người dùng đang hoạt động!");
            }
            
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
            int role = UserBLL.Instance.GetRoleIDByUserID(userID);
            if (role == 2)
            {
                InforLandlordForm form2 = new InforLandlordForm(userID);
                form2.Visible = false;
                form2.ShowDialog();
            }
            else
            {
                UserForm form1 = new UserForm(userID);
                form1.Visible = false;
                form1.ShowDialog();
            }
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

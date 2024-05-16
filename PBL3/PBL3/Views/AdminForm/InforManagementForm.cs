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
    public partial class InforManagementForm : Form
    {
        public delegate void showPostDetail(Form childForm);
        public showPostDetail showPost;
        #region ->Delegate mở lại form

        public void ReOpen()
        {
            this.Show();
            ShowDTG();
        }
        #endregion
        private static bool checkAscending = true; //kiểm tra sort ascending hay descending
        public InforManagementForm()
        {
            InitializeComponent();
            cbbSort.SelectedIndex = 0;
            cbbPostedFilter.SelectedIndex = 0;
            ShowDTG();
        }

        public void LoadHeader()
        {
            //Load lại tên các cột
            var headername = new List<string>()
            {
                "STT",
                "Post ID",
                "User ID",
                "Tên người dùng",
                "Tiêu đề",
                "Địa chỉ",
                "Số bình luận",
                "Trạng thái thuê",
                "Tạo lúc",
                "Thời gian chỉnh sửa"
            };
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = headername[i];
            }
            dgv.Columns["InforID"].Visible = false;
            dgv.Columns["UserID"].Visible = false;
            dgv.Columns["Username"].Visible = false;

        }
        public void ShowDTG()
        {
            //Hiển thị thông tin lên DTG theo các filter, search, sort
            int searchFilter = cbbPostedFilter.SelectedIndex;
            string searchChars = txtSearch.Texts;
            int sortCase = cbbSort.SelectedIndex;
            dgv.DataSource = InforBLL.Instance.GetDTGView(searchFilter, sortCase, checkAscending, searchChars);
            LoadHeader();
        }


        private void btnViewUser_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 dòng!");
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

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void cbbSort_OnSelectionChangedCommited(object sender, EventArgs e)
        {

            checkAscending = true;
            ShowDTG();

        }

        private void btnDeleteInfor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá? Sau khi xoá không thể thực hiện lại!", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    InforBLL.Instance.DeleteInfor(Convert.ToInt32(row.Cells["InforID"].Value.ToString()));
                }
                MessageBox.Show("Xoá thành công!");
                ShowDTG();
            }
            else return;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            checkAscending = !checkAscending;
            ShowDTG();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDTG();
        }

        private void btnReadInfor_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 thông tin trọ!");
                return;
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xem mỗi lần 1 thông tin trọ!");
                return;
            }

            int inforID = Convert.ToInt32(dgv.SelectedRows[0].Cells["InforID"].Value.ToString());
            InforForm form = new InforForm(Convert.ToInt32(inforID), true);
            form.goback = ReOpen;
            showPost(form);
        }

        private void cbbPostedFilter_OnSelectionChangedCommited(object sender, EventArgs e)
        {
            cbbSort.SelectedIndex = 0;
            checkAscending = true;
            ShowDTG();
        }
    }
}

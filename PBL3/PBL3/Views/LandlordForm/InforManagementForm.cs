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
using PBL3.DTO;
using PBL3.BLL;
using PBL3.Views.CommonForm;

namespace PBL3.Views.LandlordForm
{
    public partial class InforManagementForm : Form
    {
        public delegate void showPostDetail(Form childForm);
        public showPostDetail showPost;

        private static bool checkAscending = true;

        public InforManagementForm()
        {
            InitializeComponent();
            cbbSort.SelectedIndex = 0;
            cbbPostedFilter.SelectedIndex = 0;
            ShowDTG();
        }

        public void ReOpen()
        {
            this.Show();
            ShowDTG();
        }

        public void ShowDTG()
        {
            int searchFilter = cbbPostedFilter.SelectedIndex;
            string searchChars = txtSearch.Texts;
            int sortCase = cbbSort.SelectedIndex;
            dgv.DataSource = InforBLL.Instance.GetDTGView(searchFilter, sortCase, checkAscending, searchChars, LoginInfor.UserID);
            LoadHeader();
        }

        public void LoadHeader()
        {
            var headername = new List<string>()
            {
                "STT",
                "Infor ID",
                "User ID",
                "Tên người dùng",
                "Tiêu đề",
                "Địa chỉ",
                "Số bình luận",
                "Trạng thái thuê",
                "Thời gian tạo",
                "Thời gian chỉnh sửa"
            };

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = headername[i];
            }

            //Ẩn cột 
            dgv.Columns["InforID"].Visible = false;
            dgv.Columns["UserID"].Visible = false;
            dgv.Columns["Username"].Visible = false;
        }

        #region -> Click components
        //Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowDTG();
        }

        //Đăng thông tin mới
        private void btnPostInfor_Click(object sender, EventArgs e)
        {
            PostInforForm form = new PostInforForm();
            form.ShowDialog();
            ShowDTG();
        }

        //Đảo ngược thứ tự sắp xếp
        private void btnReverse_Click(object sender, EventArgs e)
        {
            checkAscending = !checkAscending;
            ShowDTG();
        }

        //Xem chi tiết thông tin trọ
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
            form.reload = ShowDTG;
            showPost(form);
        }

        //Update thông tin trọ
        private void btnUpdateInfor_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 thông tin trọ!");
                return;
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được cập nhật mỗi lần 1 thông tin trọ!");
                return;
            }

            int inforID = Convert.ToInt32(dgv.SelectedRows[0].Cells["InforID"].Value.ToString());
            UpdateInforForm form = new UpdateInforForm(inforID);
            form.Visible = false;
            form.ShowDialog();
            ShowDTG();
        }

        //Xóa thông tin 
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

        private void cbbSort_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            checkAscending = true;
            ShowDTG();
        }

        private void cbbPostedFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSort.SelectedIndex = 0;
            checkAscending = true;
            ShowDTG();
        }

        //Load cột số thứ tự tự động
        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        #endregion
        // xem lịch sử cho thuê trọ
        private void btnModifiedHistory_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Hãy chọn 1 bài thông tin trọ!");
                return;
            }
            else if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được xem thông tin mỗi lần 1 bài!");
                return;
            }
            int inforID = Convert.ToInt32(dgv.SelectedRows[0].Cells["InforID"].Value.ToString());
            InforModifiedHistoryForm form = new InforModifiedHistoryForm(Convert.ToInt32(inforID));
            form.ShowDialog(this);
        }
    }
}

using PBL3.BLL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
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

namespace PBL3.Views.LandlordForm
{
    public partial class InforModifiedHistoryForm : Form
    {
        private int InforID;

        public InforModifiedHistoryForm(int inforID)
        {
            InitializeComponent();
            InforID = inforID;
            labelName.Text = InforBLL.Instance.GetInforTitle(InforID);
            ShowDTG();
            
        }
        public void ShowDTG()
        {
            dgv.DataSource = ModifiedHistoryBLL.Instance.GetAllModifiedHistories(InforID);
            LoadHeader();
        }

        public void LoadHeader()
        {
            var headerName = new List<string>()
            {
                "STT",
                "ModifiedID",
                "InforID",
                "Infor",
                "Thời gian sửa",
                "Nội dung"
            };
            for (int i = 0; i < headerName.Count; i++)
            {
                dgv.Columns[i].HeaderText = headerName[i];
            }
            //Ẩn cột
            dgv.Columns["ModifiedID"].Visible = false;
            dgv.Columns["InforID"].Visible = false;
            dgv.Columns["AccommodationInformation"].Visible = false;
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            {
                dgv.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            }
        }
    }
}

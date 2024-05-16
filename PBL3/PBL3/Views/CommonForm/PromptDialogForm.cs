using PBL3.BLL;
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
    public partial class PromptDialogForm : Form
    {
        //Form được sử dụng để cập nhật comment của người dùng
        private int CommentID;
        public PromptDialogForm(int commentID)
        {
            InitializeComponent();
            CommentID = commentID;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            CommentBLL.Instance.UpdateComment(CommentID, customTextBox1.Text);
            this.Dispose();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CommentBLL.Instance.UpdateComment(CommentID, customTextBox1.Text);
            this.Dispose();
        }
    }
}

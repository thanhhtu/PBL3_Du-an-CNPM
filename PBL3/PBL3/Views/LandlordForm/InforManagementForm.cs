using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Views.LandlordForm
{
    public partial class InforManagementForm : Form
    {
        public delegate void showPostDetail(Form childForm);
        public showPostDetail showPost;
        public InforManagementForm()
        {
            InitializeComponent();
        }
    }
}

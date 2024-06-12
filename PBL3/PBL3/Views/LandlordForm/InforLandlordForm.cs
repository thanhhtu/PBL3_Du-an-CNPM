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
using System.Windows.Forms;

namespace PBL3.Views.LandlordForm
{
    public partial class InforLandlordForm : Form //Form hiển thị thông tin cá nhân của chủ trọ
    {
        public InforLandlordForm(int userID)
        {
            InitializeComponent();
            InitializeInformation(userID);
        }

        private void InitializeInformation(int userID)
        {
            User user = UserBLL.Instance.GetUserByID(userID);
            labelFullname.Text += " " + user.FullName;
            labelPhone.Text += " " + user.Phone;
            labelEmail.Text += " " + user.Email;
            label2.Text = AddressBLL.Instance.GetFullAddress(user.AddressID);
            labelCCCD.Text += " " + user.IDcard;
            String foderpath = ImageOfUserBLL.Instance.GetImageOfUserStoragePath(userID);
            List<String> imagepath = ImageOfUserBLL.Instance.GetImageOfUserPaths(userID);
            FrontCCCD.Image = System.Drawing.Image.FromFile(foderpath + imagepath[0]);
            BackCCCD.Image = System.Drawing.Image.FromFile(foderpath + imagepath[1]);
        }
    }
}

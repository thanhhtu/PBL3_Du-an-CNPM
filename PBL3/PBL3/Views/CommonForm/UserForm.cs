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

namespace PBL3.Views.CommonForm
{
    public partial class UserForm : Form
    {
<<<<<<< HEAD

            //Form hiển thị thông tin cá nhân
            public UserForm(int userID)
            {
                InitializeComponent();
                InitializeInformation(userID);
            }
            private void InitializeInformation(int userID)
            {
                User user = UserBLL.Instance.GetUserByID(userID);
                labelFullname.Text += user.FullName;
                labelPhone.Text += user.Phone;
                labelEmail.Text += user.Email;
                labelAddress.Text += AddressBLL.Instance.GetFullAddress(user.AddressID);
            }
        }

=======
        public UserForm(int userID)
        {
            InitializeComponent();
        }
    }
>>>>>>> 91489400e0d8a430db531856d0096fb90957b6f3
}

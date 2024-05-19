using PBL3.BLL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
using PBL3.Views.CustomComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Views.CommonForm
{
    public partial class InforForm : Form
    {
        //ID người đăng và ID bài post
        private int UserID;
        private int InforID;

        private int commentNum; //Số lượng comment có trong trang
        private int totalCommentNum; //Tổng số lượng comment của bài post
        private int currentCommentPage = 0; //Trang hiện tại của phần comment
        private int totalPage; //Số trang tổng cộng
        private int skipNum = 4; //Một lần chỉ có thể load được 4 comment
                                 // private int load 
        public InforForm(int infoID, bool HideRating = true)
        {
            InforID = infoID;
            InitializeComponent();
            InitializeFormInfomation();
            InitializeImage();
            LoadComment();
            if (HideRating) //Ẩn cmt
            {
                panel8.Visible = true;
            }
        }
        private void InitializeImage()
        {
            //Khởi tạo ảnh của bài đăng
            try
            {
                InforViewDTO post = InforBLL.Instance.GetInforByID(InforID);
                //Get folder path chứa ảnh của bài đăng có InforID
                string imagePath = ImageBLL.Instance.GetImageStoragePathsOfPost(InforID);

                System.Drawing.Image image1;
                /*
                 * Khai báo using sẽ gọi phương thức Dispose trên đối tượng khi nó ra khỏi scope.
                 * Và câu lệnh using cũng sẽ bắt đối tượng phải ra khỏi scope khi phương thức Dispose được gọi
                 * Ở trong block của using thì đối tượng là read-only và không thể modify nó
                 * Câu lệnh using cũng đảm bảo rằng phương thức Dispose() được gọi khi exception xảy ra
                 * Ví dụ dưới đây : đối tượng stream nó gọi phương thức Dispose() khi nó ra khỏi block of code
                 * Đoạn code tương ứng khi sử dụng try, finally
                 * var stream = File.OpenRead(imagePath + post.ImagePaths[0])
                 * try{
                 * image1 = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image1;
                 * } finally 
                 *      stream.Dispose();
                 */
                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[0]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                    pictureBox1.Image = image1;
                }

                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[1]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                    pictureBox2.Image = image1;
                }

                using (Stream stream = File.OpenRead(imagePath + post.ImagePaths[2]))
                {
                    image1 = System.Drawing.Image.FromStream(stream);
                    pictureBox3.Image = image1;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
        }
        public void HideHeart()
        {
            btnAddFavour.Visible = false;
            btnDeleteFavour.Visible = false;
        }
        private void InitializeFormInfomation()
        {   if (UserBLL.Instance.GetRoleIDByUserID(LoginInfor.UserID) == 1 || UserBLL.Instance.GetRoleIDByUserID(LoginInfor.UserID) == 2) { HideHeart(); }
            //Khởi tạo thông tin ban đầu của form
            InforViewDTO info = InforBLL.Instance.GetInforByID(InforID);
            labelTitle.Text = info.Title;
            labelAddress.Text = info.Address;
            labelSquareArea.Text = "Diện tích: " + info.SquareArea.ToString() + " m\u00b2";
            labelNameInfor.Text = info.Title;
            labelMoney.Text = "Số tiền: " + info.Price.ToString() + "/Tháng";
            txtDesInfor.Text = info.Description;
            labelCreateTime.Text = "Ngày đăng: " + InforBLL.Instance.GetPublishedTime(InforID);
            UserID = info.UserID.GetValueOrDefault();
            labelDeposit.Text = "Tiền đặt cọc:  " + info.Deposit.ToString();
            txtDesInfor.Texts = "Mô tả:  " + info.Description.ToString();
            if (info.LivingWithOwner) { checkBoxLivewOwner.Checked = true; }
            else
            {
                checkBoxLivewOwner.Visible = false;
                labelLiving.Text = "Không sống chung chủ";
            }
            //aitrancute đã thêm
            bool isInFavorite = FavoriteInforBLL.Instance.IsInFavorite(LoginInfor.UserID, InforID);
            if (isInFavorite)
            {
                btnDeleteFavour.BringToFront(); // Nếu có, hiển thị nút xóa yêu thích
            }
            else
            {
                btnAddFavour.BringToFront(); // Nếu không, hiển thị nút thêm yêu thích
            } //end
        }
        //Hàm được sử dụng để giấu đi phần edit và
        //delete comment nếu như comment đó không phải là của user này
        private void HideCommentUtilityFunction()
        {
            customComment1.HideUtilityPanel();
            customComment2.HideUtilityPanel();
            customComment3.HideUtilityPanel();
            customComment4.HideUtilityPanel();
        }
        private void DisplayAllCommentComponent()
        {
            this.Visible = true;
            panel3.Visible = true;
            customComment1.Visible = true;
            customComment2.Visible = true;
            customComment3.Visible = true;
            customComment4.Visible = true;
        }
        private void HideComment(int commentNum)
        {
            //Ẩn comment khi số cmt trên 1 page < 4
            switch (commentNum)
            {
                case 3:
                    customComment4.Visible = false;
                    break;
                case 2:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    break;
                case 1:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    customComment2.Visible = false;
                    break;
                case 0:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    customComment2.Visible = false;
                    customComment1.Visible = false;
                    break;
            }
        }
        private void LoadComment()
        {
            HideCommentUtilityFunction();
            DisplayAllCommentComponent();
            // panel8.Visible = false;
            totalCommentNum = CommentBLL.Instance.GetNumberOfComments(InforID);
            if (totalCommentNum == 0)
            {
                //không có gì để hiển thị
                HideComment(0);
                return;
            }
            totalPage = (int)Math.Ceiling(totalCommentNum / Convert.ToDouble(skipNum));
            /* Nếu trong trang hiện tại chỉ có 3 comment thì chỉ hiện thị 3 comment này và giấu đi comment component thứ 4
             * Còn không thì sẽ hiển thị hết
             */
            commentNum = (totalCommentNum - 4 * currentCommentPage < 4) ? totalCommentNum - 4 * currentCommentPage : 4;
            HideComment(commentNum);
            List<CommentViewDTO> comments = CommentBLL.Instance.GetCommentsView(InforID, currentCommentPage * skipNum, commentNum);
            if (customComment1.Visible)
            {
                customComment1.Comment = comments[0].Content;
                customComment1.Username = UserBLL.Instance.GetUserFullname(comments[0].UserID);
                customComment1.deleteCommentID = comments[0].CommentID;
                customComment1.editCommentID = comments[0].CommentID;
                if (UserBLL.Instance.GetRoleIDByUserID(LoginInfor.UserID) == 1)
                    customComment1.DisplayDeleteLinkLabel();
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[0].CommentID) == LoginInfor.UserID)
                    customComment1.DisplayUtilityPanel();
            }
            if (customComment2.Visible)
            {
                customComment2.Comment = comments[1].Content;
                customComment2.Username = UserBLL.Instance.GetUserFullname(comments[1].UserID);
                customComment2.deleteCommentID = comments[1].CommentID;
                customComment2.editCommentID = comments[1].CommentID;
                if (UserBLL.Instance.GetRoleIDByUserID(LoginInfor.UserID) == 1)
                    customComment2.DisplayDeleteLinkLabel();
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[1].CommentID) == LoginInfor.UserID)
                    customComment2.DisplayUtilityPanel();
            }
            if (customComment3.Visible)
            {
                customComment3.Comment = comments[2].Content;
                customComment3.Username = UserBLL.Instance.GetUserFullname(comments[2].UserID);
                customComment3.deleteCommentID = comments[2].CommentID;
                customComment3.editCommentID = comments[2].CommentID;
                if (UserBLL.Instance.GetRoleIDByUserID(LoginInfor.UserID) == 1)
                    customComment3.DisplayDeleteLinkLabel();
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[2].CommentID) == LoginInfor.UserID)
                    customComment3.DisplayUtilityPanel();
            }
            if (customComment4.Visible)
            {
                customComment4.Comment = comments[3].Content;
                customComment4.Username = UserBLL.Instance.GetUserFullname(comments[3].UserID);
                customComment4.deleteCommentID = comments[3].CommentID;
                customComment4.editCommentID = comments[3].CommentID;
                if (UserBLL.Instance.GetRoleIDByUserID(LoginInfor.UserID) == 1)
                    customComment4.DisplayDeleteLinkLabel();
                if (CommentBLL.Instance.GetUserIDByCommentID(comments[3].CommentID) == LoginInfor.UserID)
                    customComment4.DisplayUtilityPanel();
            }
        }

        private void checkBoxLivewOwner_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUpComment_Click(object sender, EventArgs e)
        {
            //Đăng cmt
            if (LoginInfor.UserID == -1)
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
                return;
            }
            if (txtComment.Texts != "")
            {
                CommentBLL.Instance.AddComment(LoginInfor.UserID, InforID, txtComment.Texts);
                txtComment.Texts = "";
            }
            else
                MessageBox.Show("Vui lòng nhập comment!");
            LoadComment();
        }

        private void btnPreviousCmt_Click(object sender, EventArgs e)
        {
            currentCommentPage = currentCommentPage - 1;
            if (currentCommentPage < 0) currentCommentPage = 0;
            LoadComment();
        }


        private void btnNextCmt_Click(object sender, EventArgs e)
        {
            currentCommentPage = currentCommentPage + 1;
            if (currentCommentPage == totalPage)
            {
                currentCommentPage = totalPage - 1;
                MessageBox.Show("Bạn đã xem hết bình luận!");
            }
            LoadComment();
        }

        private void btnInforLandLord_Click(object sender, EventArgs e)
        {
            if (LoginInfor.UserID == -1)
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
            }
            else
            {
                UserForm form = new UserForm(UserID);
                form.ShowDialog();
            }
        }
        public delegate void back();
        public back goback;

        public delegate void display();
        public display reload;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            goback();
            reload();
        }

        private void btnUpComment_Click_1(object sender, EventArgs e)
        {
            //Đăng cmt
            if (LoginInfor.UserID == -1)
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
                return;
            }
            if (txtComment.Texts != "")
            {
                CommentBLL.Instance.AddComment(LoginInfor.UserID, InforID, txtComment.Texts);
                txtComment.Texts = "";
            }
            else
                MessageBox.Show("Vui lòng nhập comment!");
            LoadComment();
        }

        private void deleteCommentEventHandler(object sender, EventArgs e)
        {

            LinkLabel linkLabel = (LinkLabel)sender;
            CustomLinkLabel customLinkLabel = (CustomLinkLabel)linkLabel.Parent;
            int commentID = customLinkLabel.ID;
            if (commentID != -1)
            {
                CommentBLL.Instance.DeleteCommentByID(commentID);
                LoadComment();
            }
        }

        private void editCommentEventHandler(object sender, EventArgs e)
        {

            //Nhấn vào link label
            LinkLabel linkLabel = (LinkLabel)sender;
            //Vì custom link label chứa id của comment nên phải ép về.
            CustomLinkLabel customLinkLabel = (CustomLinkLabel)linkLabel.Parent;
            int commentID = customLinkLabel.ID;
            if (commentID != -1)
            {
                PromptDialogForm prompt = new PromptDialogForm(customLinkLabel.ID);
                prompt.ShowDialog();
                LoadComment();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpComment_Click_2(object sender, EventArgs e)
        {
            //Đăng cmt
            if (LoginInfor.UserID == -1)
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
                return;
            }
            if (txtComment.Texts != "")
            {
                CommentBLL.Instance.AddComment(LoginInfor.UserID, InforID, txtComment.Texts);
                txtComment.Texts = "";
            }
            else
                MessageBox.Show("Vui lòng nhập comment!");
            LoadComment();
        }


        private void labelNameInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFavour_Click(object sender, EventArgs e)
        {
            if (LoginInfor.UserID == -1)
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
                return;
            }
            else
            {
                btnAddFavour.BringToFront();
                FavoriteInforBLL.Instance.DeleteFavourite_Infor(LoginInfor.UserID, InforID);
            }
        }

        private void btnAddFavour_Click(object sender, EventArgs e)
        {
            if (LoginInfor.UserID == -1)
            {
                MessageBox.Show("Bạn phải đăng nhập trước!");
                return;
            }
            else
            {
                btnDeleteFavour.BringToFront();
                FavoriteInforBLL.Instance.AddFavourite_Infor(LoginInfor.UserID, InforID);
            }
        }
    }
}


using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3.BLL
{
    public class CommentBLL
    {
        #region -> Singleton Pattern
        private static DataPBL3 db;
        private static CommentBLL _Instance;
        public static CommentBLL Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CommentBLL();
                return _Instance;
            }
            private set { }
        }
        private CommentBLL()
        {
            db = new DataPBL3();
        }
        #endregion

        #region -> Add/Update/Delete comment
        public void AddComment(int userID, int inforID, string content)
        {
            Comment comment = new Comment()
            {
                Content = content,
                UserID = userID,
                InforID = inforID,
                CreatedAt = DateTime.Now,
            };
            db.Comments.Add(comment);
            db.SaveChanges();
        }

        public void UpdateComment(int commentID, string content)
        {
            var comment = db.Comments.FirstOrDefault(c => c.CommentID == commentID);
            comment.Content = content;
            db.SaveChanges();
        }

        public void DeleteCommentByID(int commentID)
        {
            var comment = db.Comments.FirstOrDefault(c => c.CommentID == commentID);
            db.Comments.Remove(comment);
            db.SaveChanges();
        }

        //
        public void DeleteUserComment(int userID)
        {
            List<Comment> ls = db.Comments.Where(c => c.UserID == userID).ToList();
            ls.ForEach(comment => db.Comments.Remove(comment));
        }
        #endregion

        public int GetNumberOfComments(int infoID)
        {
            return db.Comments.Where(c => c.InforID == infoID).ToList().Count;
        }

        //Hiển thị comment mới nhất lên trước
        public List<CommentViewDTO> GetCommentsView(int postID, int skipNum, int commentNum)
        {
            List<CommentViewDTO> ls = new List<CommentViewDTO>();
            db.Comments.Where(c => c.InforID == postID).OrderByDescending(c => c.CreatedAt) //Sx giảm dần theo tgian tạo
                .Skip(skipNum).Take(commentNum).ToList() //phân trang
                .ForEach(c =>
                {
                    ls.Add(new CommentViewDTO()
                    {
                        Content = c.Content,
                        UserID = c.UserID,
                        CommentID = c.CommentID
                    });
                });
            return ls;
        }

        public int GetUserIDByCommentID(int commentID)
        {
            var cmt = db.Comments.Where(c => c.CommentID == commentID).FirstOrDefault();
            if (cmt == null) return -1;
            else return cmt.UserID;
        }
    }
}

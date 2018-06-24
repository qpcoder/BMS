/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Repository.EF;
    using QPC.BMS.Repository.Enum;

    class CommentRepositoryImp : ICommentRepository
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        public readonly ILoggingHelper logger;

        /// <summary>
        /// Handle instance connect to database
        /// </summary>
        BMSContext db;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        public CommentRepositoryImp()
        {
            db = new BMSContext();
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());
        }

        /// <summary>
        /// Xoa comment su dung lamdar expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public bool DeleteComment(Func<Comment, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                //kiem tra comment co ton tai trong he thong
                List<Comment> lstComment = db.Comments.Where(expression).ToList();
                if (lstComment == null) throw new Exception(MessageReponsitory.COMMENT_NOT_EXISTS);

                //xoa tung comment
                foreach (Comment c in lstComment)
                {
                    db.Comments.Remove(c);
                }

                //cap nhat cac thay doi len database
                db.SaveChanges();

                logger.Info(MessageReponsitory.DELETE_DATA_SUCCESSFUL);
                return true;
            }
            catch (Exception e)
            {
                logger.Error($"{MessageReponsitory.DELETE_DATA_UNSUCCESSFUL}");
                logger.Debug($"{MessageReponsitory.DELETE_DATA_UNSUCCESSFUL} Error message: {e.Message}");
                throw new Exception($"{MessageReponsitory.DELETE_DATA_UNSUCCESSFUL} Error message: {e.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// Xoa comment su dung comment id
        /// </summary>
        /// <param name="commentID"></param>
        /// <returns></returns>
        public bool DeleteComment(int commentID)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                //kiem tra comment co ton tai trong he thong
                Comment comment = db.Comments.Where(x => x.ID.Equals(commentID)).FirstOrDefault();
                if (comment == null) throw new Exception(MessageReponsitory.COMMENT_NOT_EXISTS);

                //xoa tung comment
                db.Comments.Remove(comment);

                //cap nhat cac thay doi len database
                db.SaveChanges();

                logger.Info(MessageReponsitory.DELETE_DATA_SUCCESSFUL);
                return true;
            }
            catch (Exception e)
            {
                logger.Error($"{MessageReponsitory.DELETE_DATA_UNSUCCESSFUL}");
                logger.Debug($"{MessageReponsitory.DELETE_DATA_UNSUCCESSFUL} Error message: {e.Message}");
                throw new Exception($"{MessageReponsitory.DELETE_DATA_UNSUCCESSFUL} Error message: {e.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// Chinh sua noi dung comment su dung lamdar expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public bool EditComment(Func<Comment, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                db.Comments.Where(expression);
                db.SaveChanges();

                logger.Info(MessageReponsitory.UPDATE_DATA_SUCCESSFUL);
                return true;
            }
            catch (Exception e)
            {
                logger.Error($"{MessageReponsitory.UPDATE_DATA_UNSUCCESSFUL}");
                logger.Debug($"{MessageReponsitory.UPDATE_DATA_UNSUCCESSFUL} Error detail: {e.Message}");
                throw new Exception($"{MessageReponsitory.UPDATE_DATA_UNSUCCESSFUL} Error detail: {e.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// Chinh sua noi dung comment su dung object comment
        /// </summary>
        /// <param name="modelEdit"></param>
        /// <returns></returns>
        public bool EditComment(Comment modelEdit)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                Comment comment = db.Comments.Where(x => x.ID.Equals(modelEdit.ID)).FirstOrDefault();

                if (comment == null) throw new Exception(MessageReponsitory.COMMENT_NOT_EXISTS);

                comment.Content = modelEdit.Content;
                comment.IPAddress = modelEdit.IPAddress;

                db.SaveChanges();

                logger.Info(MessageReponsitory.UPDATE_DATA_SUCCESSFUL);
                return true;
            }
            catch (Exception e)
            {
                logger.Error($"{MessageReponsitory.UPDATE_DATA_UNSUCCESSFUL}");
                logger.Debug($"{MessageReponsitory.UPDATE_DATA_UNSUCCESSFUL} Error detail: {e.Message}");
                throw new Exception($"{MessageReponsitory.UPDATE_DATA_UNSUCCESSFUL} Error detail: {e.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// Lay tat ca comment 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Comment> GetAllComments(int postID)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                List<Comment> lstComment = db.Comments.Where(x => x.PostID.Equals(postID)).ToList();

                //kiem tra xem co ton tai comment nao khong
                if (lstComment == null) throw new Exception(MessageReponsitory.POST_NOT_COMMENT);

                logger.Info(MessageReponsitory.SEARCH_SUCCESSFUL);
                return lstComment;
            }
            catch (Exception e)
            {
                logger.Error($"{MessageReponsitory.NOT_RESULT}");
                logger.Debug($"{MessageReponsitory.NOT_RESULT} Message: {e.Message}");
                throw new Exception($"{MessageReponsitory.NOT_RESULT} Message: {e.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// Lay comment theo id
        /// </summary>
        /// <param name="commentID"></param>
        /// <returns></returns>
        public Comment GetComment(int commentID, int postID)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                Comment comment = db.Comments.Where(x => x.ID.Equals(commentID) & x.PostID.Equals(postID)).FirstOrDefault();

                //kiem tra xem co ton tai comment nao khong
                if (comment == null) throw new Exception(MessageReponsitory.POST_NOT_COMMENT);

                logger.Info(MessageReponsitory.SEARCH_SUCCESSFUL);
                return comment;
            }
            catch (Exception e)
            {
                logger.Error($"{MessageReponsitory.NOT_RESULT}");
                logger.Debug($"{MessageReponsitory.NOT_RESULT} Message: {e.Message}");
                throw new Exception($"{MessageReponsitory.NOT_RESULT} Message: {e.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// Lay comment theo lamdar expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<Comment> GetComment(Func<Comment, bool> expression)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                List<Comment> lstComment = db.Comments.Where(expression).ToList();

                //kiem tra xem co ton tai comment nao khong
                if (lstComment == null) throw new Exception(MessageReponsitory.POST_NOT_COMMENT);

                logger.Info(MessageReponsitory.SEARCH_SUCCESSFUL);
                return lstComment;
            }
            catch (Exception e)
            {
                logger.Error($"{MessageReponsitory.NOT_RESULT}");
                logger.Debug($"{MessageReponsitory.NOT_RESULT} Message: {e.Message}");
                throw new Exception($"{MessageReponsitory.NOT_RESULT} Message: {e.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        /// <summary>
        /// Them comment moi
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool SetComment(Comment model)
        {
            //log enter method
            logger.EnterMethod();

            try
            {
                if (db.Accounts.Where(x => x.ID.Equals(model.AccountID)).FirstOrDefault() == null)
                    throw new Exception(MessageReponsitory.ACCOUNT_NOT_EXISTS);
                return true;
                
            }
            catch (Exception ex)
            {
                logger.Error($"{MessageReponsitory.INSERT_DATA_UNSUCCESSFUL}");
                logger.Debug($"{MessageReponsitory.INSERT_DATA_UNSUCCESSFUL} Message: {ex.Message}");
                throw new Exception($"{MessageReponsitory.INSERT_DATA_UNSUCCESSFUL} Message: {ex.Message}");
            }
            finally
            {
                //log release method
                logger.ReleaseMethod();
            }
        }

        public bool SetComment(List<Comment> models)
        {
            throw new NotImplementedException();
        }
    }
}

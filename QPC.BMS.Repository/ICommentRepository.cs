/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using QPC.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;

    public interface ICommentRepository
    {
        #region Table Comment

        /// <summary>
        /// Get all comments
        /// </summary>
        /// <param name="postID"></param>
        /// <returns></returns>
        IEnumerable<Comment> GetAllComments(int postID);

        /// <summary>
        /// Get comment by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list comments</returns>
        IEnumerable<Comment> GetComment(Func<Comment, bool> expression);

        /// <summary>
        /// Get comment by id
        /// </summary>
        /// <param name="commentID">comment id</param>
        /// <returns>object comment</returns>
        Comment GetComment(int commentID, int postID);

        /// <summary>
        /// Insert list comment into database
        /// </summary>
        /// <param name="models">list comments</param>
        /// <returns>true or false</returns>
        Boolean SetComment(List<Comment> models);

        /// <summary>
        /// Insert object into comment
        /// </summary>
        /// <param name="models">object comment</param>
        /// <returns>true or false</returns>
        Boolean SetComment(Comment models);

        /// <summary>
        /// Update comment by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditComment(Func<Comment, bool> expression);

        /// <summary>
        /// Update comment by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditComment(Comment modelEdit);

        /// <summary>
        /// Delete comment by ID
        /// </summary>
        /// <param name="logID">comment id</param>
        /// <returns>true or false</returns>
        Boolean DeleteComment(int commentID);

        /// <summary>
        /// Delete comment by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteComment(Func<Comment, bool> expression);

        #endregion
    }
}

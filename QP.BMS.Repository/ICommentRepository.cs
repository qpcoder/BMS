/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Repository
{
    using QP.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;

    public interface ICommentRepository
    {
        #region Table Download

        /// <summary>
        /// Get all comments
        /// </summary>
        /// <returns>list comments</returns>
        IEnumerable<Comment> GetAllComments();

        /// <summary>
        /// Get comment by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list comments</returns>
        IEnumerable<Comment> GetCommentsByExpression(Func<Comment, bool> expression);

        /// <summary>
        /// Get comment by id
        /// </summary>
        /// <param name="commentID">comment id</param>
        /// <returns>object comment</returns>
        Comment GetCommentByID(Guid commentID);

        /// <summary>
        /// Insert list comment into database
        /// </summary>
        /// <param name="models">list comments</param>
        /// <returns>true or false</returns>
        Boolean SetListComments(List<Comment> models);

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
        Boolean EditCommentByExpression(Func<Comment, bool> expression);

        /// <summary>
        /// Update comment by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditCommentByObject(Comment modelEdit);

        /// <summary>
        /// Delete comment by ID
        /// </summary>
        /// <param name="logID">comment id</param>
        /// <returns>true or false</returns>
        Boolean DeleteCommentByID(Guid commentID);

        /// <summary>
        /// Delete comment by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteCommentByExpression(Func<Comment, bool> expression);

        /// <summary>
        /// Delete all comments
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllComments();

        #endregion
    }
}

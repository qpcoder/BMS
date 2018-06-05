/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QP.BMS.Repository.EF;

    public class CommentRepositoryImp : ICommentRepository
    {
        public CommentRepositoryImp()
        {
        }

        public bool DeleteAllComments()
        {
            throw new NotImplementedException();
        }

        public bool DeleteCommentByExpression(Func<Comment, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCommentByID(Guid commentID)
        {
            throw new NotImplementedException();
        }

        public bool EditCommentByExpression(Func<Comment, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditCommentByObject(Comment modelEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAllComments()
        {
            throw new NotImplementedException();
        }

        public Comment GetCommentByID(Guid commentID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentsByExpression(Func<Comment, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool SetComment(Comment models)
        {
            throw new NotImplementedException();
        }

        public bool SetListComments(List<Comment> models)
        {
            throw new NotImplementedException();
        }
    }
}

/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Repository.DependencyResolution
{
    using StructureMap;

    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            #region Constructors and Destructors
            For<IAccountRepository>().Use<AccountRepositoryImp>().Name = "Account_v1";
            For<IPostRepository>().Use<PostRepositoryImp>().Name = "Post_v1";
            For<ICommentRepository>().Use<CommentRepositoryImp>().Name = "Comment_v1";
            For<ISystemRepository>().Use<SystemRepositoryImp>().Name = "System_v1";
            #endregion
        }
    }
}

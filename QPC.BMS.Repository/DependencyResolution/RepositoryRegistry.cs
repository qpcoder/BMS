/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.DependencyResolution
{
    using QPC.BMS.Helpers.Enum;
    using StructureMap;

    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            #region Constructors and Destructors
            For<IAccountRepository>().Use<AccountRepositoryImp>().Name
                = TargetImplement.V1.ToString();
            For<IPostRepository>().Use<PostRepositoryImp>().Name 
                = TargetImplement.V1.ToString();
            For<ICommentRepository>().Use<CommentRepositoryImp>().Name 
                = TargetImplement.V1.ToString();
            For<ISystemConfigurationRepository>().Use<SystemConfigurationRepositoryImp>().Name 
                = TargetImplement.V1.ToString();
            For<ICommonRepository>().Use<CommonRepositoryImp>().Name 
                = TargetImplement.V1.ToString();
            #endregion
        }
    }
}

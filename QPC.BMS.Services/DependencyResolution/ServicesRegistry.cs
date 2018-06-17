/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Services.DependencyResolution
{
    using QPC.BMS.Helpers.Enum;
    using StructureMap;

    public class ServicesRegistry : Registry
    {
        public ServicesRegistry()
        {
            #region Constructors and Destructors
            For<IAccountServices>().Use<AccountServicesImp>().Name = TargetImplement.V1.ToString();
            #endregion
        }
    }
}

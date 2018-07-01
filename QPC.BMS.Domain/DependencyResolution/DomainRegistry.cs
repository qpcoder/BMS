/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using QPC.BMS.Domain.AutoMapper;
using QPC.BMS.Helpers.Enum;
using QPC.BMS.Models;
using QPC.BMS.Repository.EF;
using StructureMap;

namespace QPC.BMS.Domain.DependencyResolution
{
    public class DomainRegistry : Registry
    {
        /// <summary>
        /// Hàm đăng ký với các tất cả các version 
        /// </summary>
        /// <param name="targetImplement"></param>
        public DomainRegistry()
        {

            #region Constructors and Destructors target version 1
            For<IBaseMapper<SystemExceptionLogModel, SystemExceptionLog>>().Use<SystemExceptionLogMapperImpV1>().Name = TargetImplement.V1.ToString();
            For<IBaseMapper<AccountModel, Account>>().Use<AccountMapperImpV1>().Name = TargetImplement.V1.ToString();
            #endregion

            #region Constructors and Destructors target version 2
            For<IBaseMapper<SystemExceptionLogModel, SystemExceptionLog>>().Use<SystemExceptionLogMapperImpV1>().Name = TargetImplement.V2.ToString();
            For<IBaseMapper<AccountModel, Account>>().Use<AccountMapperImpV1>().Name = TargetImplement.V2.ToString();
            #endregion

        }
    }
}

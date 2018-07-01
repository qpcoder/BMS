/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using QPC.BMS.Domain.AutoMapper;
using QPC.BMS.Helpers.Enum;
using QPC.BMS.Models;
using QPC.BMS.Repository.EF;

namespace QPC.BMS.Domain
{
    public class DomainTier
    {

        public IBaseMapper<AccountModel, Account> AccountMapper;
        public IBaseMapper<SystemExceptionLogModel, SystemExceptionLog> SystemExceptionLogMapper;

        public DomainTier(TargetImplement targetImplement = TargetImplement.V1)
        {
            switch (targetImplement)
            {
                case TargetImplement.V1:
                    {
                        AccountMapper = Domain.DependencyResolution.IoC.Container().GetInstance<IBaseMapper<AccountModel, Account>>(TargetImplement.V1.ToString());
                        SystemExceptionLogMapper = Domain.DependencyResolution.IoC.Container().GetInstance<IBaseMapper<SystemExceptionLogModel, SystemExceptionLog>>(TargetImplement.V1.ToString());
                        break;
                    }
                case TargetImplement.V2:
                    {
                        break;
                    }
                default:
                    break;
            }
        }
    }
}

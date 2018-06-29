/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QPC.BMS.Domain.AutoMapper;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Models;
    using QPC.BMS.Repository;

    public class SystemServicesImp : BaseServices, ISystemServices
    {
        private ISystemRepository systemRepository;

        public SystemServicesImp()
        {
            systemRepository = Repository.DependencyResolution.IoC.Container().GetInstance<ISystemRepository>(TargetImplement.V1.ToString());
        }

        public bool CreateDatabase()
        {
            throw new NotImplementedException();
        }

        public bool SetSystemExceptionLog(SystemExceptionLogModel logModel)
        {
            throw new NotImplementedException();
        }
    }
}

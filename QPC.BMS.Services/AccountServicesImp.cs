/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Services
{
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AccountServicesImp : IAccountServices
    {
        /// <summary>
        /// Handle instance for Log4Net
        /// </summary>
        //ILoggingHelper logger = Helpers.DependencyResolution.IoC.Container()
        //    .GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

        /// <summary>
        /// Handle instance for account repository
        /// </summary>
        //IAccountRepository accountRepository = Repository.DependencyResolution.IoC.Container()
        //    .GetInstance<IAccountRepository>(TargetImplement.V1.ToString());

        public bool Login(string userName, string passWord)
        {
            //accountRepository.GetAccount(x => x.UserName == userName && x.Password == passWord);
            return true;
        }
    }
}

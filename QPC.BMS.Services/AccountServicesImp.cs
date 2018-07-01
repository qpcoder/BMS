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

    public class AccountServicesImp : BaseServices, IAccountServices
    {
        /// <summary>
        /// Hàm khởi tạo các đối tượng cần sử dụng cho toàn class
        /// </summary>
        public AccountServicesImp()
        {
            accountRepository = Repository.DependencyResolution.IoC.Container()
           .GetInstance<IAccountRepository>(TargetImplement.V1.ToString());
        }

        public bool Login(string userName, string passWord)
        {
            //accountRepository.GetAccount(x => x.UserName == userName && x.Password == passWord);
            return true;
        }
    }
}

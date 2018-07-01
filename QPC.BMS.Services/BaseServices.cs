/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using QPC.BMS.Helpers;
using QPC.BMS.Helpers.Enum;
using QPC.BMS.Repository;
using QPC.BMS.Domain.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QPC.BMS.Models;
using QPC.BMS.Domain;

namespace QPC.BMS.Services
{

    /// <summary>
    /// Những khai náo cơ bản
    /// Dùng cho tầng Services 
    /// </summary>
    public class BaseServices
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        internal readonly ILoggingHelper logger;

        /// <summary>
        /// Handle instance for account repository
        /// </summary>
        internal IAccountRepository accountRepository;

        /// <summary>
        /// Handle instance for system repository
        /// </summary>
        internal ISystemRepository systemRepository;

        /// <summary>
        /// Định nghĩa các đối tượng cần dùng ở tâng Domain
        /// </summary>
        internal DomainTier domainTier;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        public BaseServices()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());
            domainTier = new DomainTier(TargetImplement.V1);
        }
    }
}

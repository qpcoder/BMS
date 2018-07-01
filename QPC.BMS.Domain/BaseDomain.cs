/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Domain
{
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using global::AutoMapper;

    public class BaseDomain
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        internal readonly ILoggingHelper logger;

        /// <summary>
        /// Biến khai báo đối tượng automapper
        /// </summary>
        internal IMapper mapper;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        public BaseDomain()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());
        }
    }
}

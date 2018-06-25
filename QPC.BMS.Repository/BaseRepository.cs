/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Repository.EF;

    public class BaseRepository
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        internal readonly ILoggingHelper logger;

        /// <summary>
        /// Handle instance for Connection database 
        /// </summary>
        internal BMSContext db;

        /// <summary>
        /// Dependency Injection 
        /// </summary>
        public BaseRepository()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

            db = new BMSContext();
        }
    }
}

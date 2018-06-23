/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Helpers.DependencyResolution
{
    using QPC.BMS.Helpers.Enum;
    using StructureMap;

    /// <summary>
    /// Handle registry of helper project for structure map
    /// </summary>
    public class HelperRegistry: Registry
    {
        /// <summary>
        /// Handle class helper registry
        /// </summary>
        public HelperRegistry()
        {
            #region Constructors and Destructors
            //For<ISpeedSMSHelper>().Use<SpeedSmsImp>().Name = TargetImplement.V1.ToString();
            //For<IEmailHelper>().Use<EmailHelperImp>().Name = TargetImplement.V1.ToString();
            //For<IValidateHelper>().Use<ValidateHelperImp>().Name = TargetImplement.V1.ToString();
            For<ILoggingHelper>().Use<LoggingHelperImp>().Name = TargetImplement.V1.ToString();
            #endregion
        }
    }
}

/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPCODERS.Utilities.DependencyResolution
{
    using QPCODERS.Utilities.Helpers;
    using StructureMap;

    public class UtilityRegistry : Registry
    {
        public UtilityRegistry()
        {
            #region Constructors and Destructors
            For<ISpeedSMSHelper>().Use<SpeedSmsImp>().Name = "SpeedSMS";
            For<IEmailHelper>().Use<EmailImp>();
            For<IValidateHelper>().Use<ValidateImp>();
            For<ILoggerHelper>().Use<LogCustomImp>().Name = "Logger";
            #endregion
        }
    }
}

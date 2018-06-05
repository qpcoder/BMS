/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Domain.DependencyResolution
{
    using StructureMap;

    public class DomainRegistry : Registry
    {
        public DomainRegistry()
        {
            #region Constructors and Destructors
            //For<ISpeedSMSHelper>().Use<SpeedSmsImp>().Name = "SpeedSMS";
            //For<IEmailHelper>().Use<EmailImp>();
            //For<IValidateHelper>().Use<ValidateImp>();
            //For<ILoggerHelper>().Use<LogCustomImp>().Name = "Logger";
            #endregion
        }
    }
}

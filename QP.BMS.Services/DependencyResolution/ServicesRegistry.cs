/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Services.DependencyResolution
{
    using StructureMap;

    public class ServicesRegistry : Registry
    {
        public ServicesRegistry()
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

/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using QPCODERS.Utilities.DependencyResolution;
using QPCODERS.Utilities.Enum;
using QPCODERS.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPCODERS.Utilities
{
    class Program
    {
        private ISpeedSMSHelper speedSms = IoC.Container().GetInstance<ISpeedSMSHelper>();

        private ILoggerHelper logger = IoC.Container().GetInstance<ILoggerHelper>();

        static void Main(string[] args)
        {
        }

        string TestSpeedSMS(string[] phones, string sContent, SMSTypeEnum eSmsType, string sSender)
        {
            speedSms.AccessToken = "kG_HbPcVS9QsK4rCb56RYmNk0hbGhuaI";

            String response = speedSms.SendSMS(phones, sContent, eSmsType, sSender);
            return response;
        }
    }
}

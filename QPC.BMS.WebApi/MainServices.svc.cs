/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QPC.BMS.WebApi
{
    /// NOTE: 
    /// You can use the "Rename" command on the "Refactor" menu to change the class name "MainServices" in code, svc and config file together.
    /// In order to launch WCF Test Client for testing this service, please select MainServices.svc or MainServices.svc.cs at the Solution Explorer and start debugging.
    public class MainServices : IMainServices
    {
        public string GetMessage()
        {
            return "Welcome to tungnt.net from GetMessage() WCF REST Service";
        }

        public string PostMessage(string userName)
        {
            return string.Format("Welcome {0} to tungnt.net from PostMessage() WCF REST Service", userName);
        }
    }
}

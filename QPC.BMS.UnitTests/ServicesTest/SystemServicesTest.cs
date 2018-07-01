/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QPC.BMS.Services;

namespace QPC.BMS.UnitTests.ServicesTest
{
    [TestClass]
    public class SystemServicesTest
    {
        /// <summary>
        /// Khởi tạo đối tường test 
        /// </summary>
        SystemServicesImp systemServicesImp = new SystemServicesImp();

        [TestMethod]
        public void SetSystemExceptionLog()
        {
            Exception exception = new SystemException("Unit test exeption") { HelpLink = "www.qpcoders.com", Source = "a/s/w/d" };
            systemServicesImp.SetSystemExceptionLog(exception);
        }
    }
}

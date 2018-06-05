/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System.Collections.Generic;

namespace QPCODERS.Utilities.Helpers
{
    public interface IEmailHelper
    {
        string FromEmail { get; set; }
        string Password { get; set; }
        string Host { get; set; }
        int Port { get; set; }
        bool EnableSsl { get; set; }

        /// <summary>
        /// Send a email 
        /// </summary>
        /// <param name="sToEmail">Nguoi nhan</param>
        /// <param name="sSubject">Tieu de email</param>
        /// <param name="sBody">noi dung email</param>
        /// <param name="lstAttached">Attach Files</param>
        /// <returns>Bool</returns>
        bool SendEmail(string sToEmail, string sSubject, string sBody, List<string> lstAttached = null);
    }
}

/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPC.BMS.Helpers
{
    using log4net;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Mail;
    using System.Threading;

    public class EmailHelperImp : IEmailHelper
    {
        public string Password { get { return Password; } set { Password = value; } }
        public string Host { get { return Host; } set { Host = value; } }
        public int Port { get { return Port; } set { Port = value; } }
        public bool EnableSsl { get { return EnableSsl; } set { EnableSsl = value; } }
        public string FromEmail { get { return FromEmail; } set { FromEmail = value; } }

        /// <summary>
        /// Send a email 
        /// </summary>
        /// <param name="sToEmail">Người nhận</param>
        /// <param name="sSubject">Tiêu đề email</param>
        /// <param name="sBody">nội dung email</param>
        /// <param name="lstAttached">Attach Files</param>
        /// <returns>Bool</returns>
        public bool SendEmail(string sToEmail, string sSubject, string sBody, List<string> lstAttached = null)
        {
            Thread threadSendMails;
            threadSendMails = new Thread(delegate ()
            {

                var loginInfo = new NetworkCredential(FromEmail, Password);
                var msg = new MailMessage();
                var smtpClient = new SmtpClient();
                Host = "smtp.gmail.com";
                Port = 587;
                EnableSsl = true;

                msg.From = new MailAddress(FromEmail);
                msg.To.Add(new MailAddress(sToEmail));
                msg.Subject = sSubject;
                msg.Body = sBody;
                msg.IsBodyHtml = true;

                smtpClient.Host = Host;
                smtpClient.Port = Port;
                smtpClient.EnableSsl = EnableSsl;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = loginInfo;
                smtpClient.Send(msg);

            });

            threadSendMails.IsBackground = true;
            threadSendMails.Start();
            return true;
        }
    }
}

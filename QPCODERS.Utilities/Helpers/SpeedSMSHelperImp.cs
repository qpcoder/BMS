/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPCODERS.Utilities.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Net;
    using System.IO;
    using log4net;
    using QPCODERS.Utilities.Enum;
    using QPCODERS.Utilities.DependencyResolution;

    public class SpeedSmsImp : ISpeedSMSHelper
    {
        /// <summary>
        /// Declare instance for log4net
        /// </summary>
        private readonly ILoggerHelper logger =
            IoC.Container().GetInstance<ILoggerHelper>();

        private readonly String rootURL = "https://api.speedsms.vn/index.php";
        private String accessToken = "";

        /// <summary>
        /// Token la chung chi de thao tac trong he thong speedsms
        /// </summary>
        public string AccessToken
        {
            get => accessToken;
            set => accessToken = value;
        }

        /// <summary>
        /// Duong dan mac dinh cua speedsms
        /// </summary>
        public string RootURL => rootURL;

        /// <summary>
        /// Ham khoi tao khong tham so
        /// </summary>
        public SpeedSmsImp()
        {

        }

        /// <summary>
        /// Ham khoi tao co truyen tham so token
        /// </summary>
        /// <param name="token"></param>
        public SpeedSmsImp(String token)
        {
            AccessToken = token;
        }

        /// <summary>
        /// Ma hoa cac ky tu khong phai ACSII
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string EncodeNonAsciiCharacters(string value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in value)
            {
                if (c > 127)
                {
                    // This character is too big for ASCII
                    string encodedValue = "\\u" + ((int)c).ToString("x4");
                    sb.Append(encodedValue);
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Lay thong tin user
        /// </summary>
        /// <returns></returns>
        public string GetUserInfo()
        {
            String url = rootURL + "/user/info";
            NetworkCredential myCreds = new NetworkCredential(AccessToken, ":x");
            WebClient client = new WebClient();
            client.Credentials = myCreds;
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            return reader.ReadToEnd();
        }

        /// <summary>
        /// Gui tin nhan toi mobile
        /// </summary>
        /// <param name="phones"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <param name="sender"></param>
        /// <returns></returns>
        public String SendSMS(string[] phones, string content, SMSTypeEnum type, string sender)
        {
            String url = rootURL + "/sms/send";
            if (phones.Length <= 0)
                return "";
            if (content.Equals(""))
                return "";

            if (type == SMSTypeEnum.TYPE_BRANDNAME && sender.Equals(""))
                return "";
            if (!sender.Equals("") && sender.Length > 11)
                return "";

            NetworkCredential myCreds = new NetworkCredential(accessToken, ":x");
            WebClient client = new WebClient();
            client.Credentials = myCreds;
            client.Headers[HttpRequestHeader.ContentType] = "application/json";

            string builder = "{\"to\":[";

            for (int i = 0; i < phones.Length; i++)
            {
                builder += "\"" + phones[i] + "\"";
                if (i < phones.Length - 1)
                {
                    builder += ",";
                }
            }
            builder += "], \"content\": \"" + EncodeNonAsciiCharacters(content) + "\", \"type\":" + type + ", \"sender\": \"" + sender + "\"}";

            String json = builder.ToString();
            return client.UploadString(url, json);
        }

        /// <summary>
        /// Tao cuoc goi toi khach hang
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public string SendVOICE(string phone, string content)
        {
            string _url = RootURL + "/voice/otp";

            NetworkCredential _myCreds = new NetworkCredential(AccessToken, ":x");
            WebClient _client = new WebClient();
            _client.Credentials = _myCreds;
            _client.Headers[HttpRequestHeader.ContentType] = "application/json";

            string builder = "{\"to\":\"";
            builder += phone;
            builder += "\",\"content\":\"";
            builder += content;
            builder += "\"}";

            string _json = builder.ToString();
            return _client.UploadString(_url, _json);
        }

        /// <summary>
        /// Doc chuoi JSon duoc tra ve tu SpeedSMS
        /// </summary>
        /// <param name="jsonSpeedSMS"></param>
        /// <returns></returns>
        public Dictionary<string, string> ReadResponSpeedSMS(string jsonSpeedSMS)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Kiem tra trang thai tin nhan
        /// </summary>
        /// <param name="smsID"></param>
        /// <returns></returns>
        public string CheckStatusSMS(string smsID)
        {
            throw new NotImplementedException();
        }
    }
}

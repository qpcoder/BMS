/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace AdvertisingOnline.Helpers
{
    using Newtonsoft.Json.Linq;
    using QPC.BMS.Domain;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;

    public class SpeedSMSHelper : BaseDomain
    {
        public const int TYPE_QC = 1;
        public const int TYPE_CSKH = 2;
        public const int TYPE_BRANDNAME = 3;
        const String rootURL = "http://api.speedsms.vn/index.php";
        private String accessToken = "uK2qqG3rcO8h9xa5Uun8C9ED4m_F2EuC";
        //https://connect.speedsms.vn
        //email: vinhthang@esms.vn, pass: StrongPass1
        //private String accessToken = "DOuVMbhicZdkNxVgCkz7yA8jbmERP-4i";
        //users: sangng@vihat.vn
        //pass:VT2@ji
        public SpeedSMSHelper() { }
        //public SpeedSMSHelper(String token)
        //{
        //    this.accessToken = token;
        //}

        public String getUserInfo()
        {
            String url = rootURL + "/user/info";
            NetworkCredential myCreds = new NetworkCredential(accessToken, ":x");
            WebClient client = new WebClient();
            client.Credentials = myCreds;
            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            return reader.ReadToEnd();
        }

        public String sendSMS(String phone, String content, String brandname, int type = 2)
        {
            try
            {
                String url = rootURL + "/sms/send";
                if (phone.Length <= 0 || phone.Length < 10 || phone.Length > 11)
                    return "";
                if (content.Equals(""))
                    return "";
                if (type < TYPE_QC || type > TYPE_BRANDNAME)
                    return "";
                if (type == TYPE_BRANDNAME && brandname.Equals(""))
                    return "";
                if (!brandname.Equals("") && brandname.Length > 11)
                    return "";
                content = content.Replace("\"", "'");
                content = content.Replace("\n", "\\n");
                NetworkCredential myCreds = new NetworkCredential(accessToken, ":x");
                WebClient client = new WebClient();
                client.Credentials = myCreds;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                String json = "{\"to\":[\"" + phone + "\"], \"content\": \"" + content + "\", \"sms_type\":" + type + ", \"brandname\": \"" + brandname + "\"}";
                var result = client.UploadString(url, json);
                JObject ojb = JObject.Parse(result);
                string CodeResult = (string)ojb["status"];//trả về success là thành công
                string CountRegenerate = (string)ojb["code"];
                string MessageERORR = (string)ojb["message"];//id của tin nhắn
                if (CodeResult != "success")
                {
                    return CodeResult + "|" + CountRegenerate + "|" + MessageERORR + "|" + json + "|" + url;
                }
                else
                {
                    return CodeResult;
                }
            }
            catch (Exception)
            {
                return "Speedsms | timeout";
                //throw;
            }
            
        }

        public String sendSMSSpeedType8(String phone, String content, String brandname, int type = 2)
        {
            try
            {
                String url = rootURL + "/sms/send";
                if (phone.Length <= 0 || phone.Length < 10 || phone.Length > 11)
                    return "";
                if (content.Equals(""))
                    return "";              
                if (type == TYPE_BRANDNAME && brandname.Equals(""))
                    return "";
                if (!brandname.Equals("") && brandname.Length > 11)
                    return "";
                content = content.Replace("\"", "'");
                content = content.Replace("\n", "\\n");
                NetworkCredential myCreds = new NetworkCredential(accessToken, ":x");
                WebClient client = new WebClient();
                client.Credentials = myCreds;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";

                String json = "{\"to\":[\"" + phone + "\"], \"content\": \"" + content + "\", \"sms_type\":" + type + ", \"brandname\": \"" + brandname + "\"}";
                var result = client.UploadString(url, json);
                JObject ojb = JObject.Parse(result);
                string CodeResult = (string)ojb["status"];//trả về success là thành công
                string CountRegenerate = (string)ojb["code"];
                string MessageERORR = (string)ojb["message"];//id của tin nhắn
                if (CodeResult != "success")
                {
                    return CodeResult + "|" + CountRegenerate + "|" + MessageERORR + "|" + json + "|" + url;
                }
                else
                {
                    return CodeResult;
                }
            }
            catch (Exception)
            {
                return "Speedsms | timeout";
                throw;
            }

        }

        //SpeedSMSAPI api = new SpeedSMSAPI();
        //String userInfo = api.getUserInfo();
        //String response = api.sendSMS("0909935469", "test sms nhe", 2, "");
    }
}
/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPCODERS.Utilities.Helpers
{
    using QPCODERS.Utilities.Enum;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ISpeedSMSHelper
    {

        /// <summary>
        /// Duong dan mac dinh cua speedsms
        /// </summary>
        string RootURL { get; }

        /// <summary>
        /// Token la chung chi de thao tac trong he thong speedsms
        /// </summary>
        String AccessToken { set; get; }

        /// <summary>
        /// Lay thong tin user
        /// </summary>
        /// <returns></returns>
        String GetUserInfo();

        /// <summary>
        /// Gui tin nhan toi mobile
        /// </summary>
        /// <param name="phones"></param>
        /// <param name="content"></param>
        /// <param name="type"></param>
        /// <param name="sender"></param>
        /// <returns></returns>
        String SendSMS(String[] phones, String content, SMSTypeEnum eSmsType, String sender);

        /// <summary>
        /// Tao cuoc goi toi khach hang
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        String SendVOICE(string phone, string content);

        /// <summary>
        /// Kiem tra trang thai tin nhan
        /// </summary>
        /// <param name="smsID"></param>
        /// <returns></returns>
        String CheckStatusSMS(string smsID);

        /// <summary>
        /// Doc chuoi JSon duoc tra ve tu SpeedSMS
        /// </summary>
        /// <param name="jsonSpeedSMS"></param>
        /// <returns></returns>
        Dictionary<string, string> ReadResponSpeedSMS(string jsonSpeedSMS);
    }
}

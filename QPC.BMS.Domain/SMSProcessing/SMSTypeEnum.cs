/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Helpers.Enum
{
    public enum SMSTypeEnum
    {
        TYPE_QC = 1,

        TYPE_CSKH = 2,

        TYPE_BRANDNAME = 3,

        /// <summary>
        /// Gui sms su dung brandname Notify
        /// </summary>
        TYPE_BRANDNAME_NOTIFY = 4,

        /// <summary>
        /// Gui sms su dung app android tu so dien thoai ca nhan
        /// download app tai day: //play.google.com/store/apps/details?id=com.speedsms.gateway
        /// </summary>
        TYPE_GATEWAY = 5,

        /// <summary>
        /// sms gui bang dau so co dinh 0901756186
        /// </summary>
        TYPE_FIXNUMBER = 6,

        /// <summary>
        /// sms gui bang dau so rieng da duoc dang ky voi SpeedSMS
        /// </summary>
        TYPE_OWN_NUMBER = 7,

        /// <summary>
        /// sms gui bang dau so co dinh 2 chieu
        /// </summary>
        TYPE_TWOWAY_NUMBER = 8
    }
}

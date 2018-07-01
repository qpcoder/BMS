using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QPC.BMS.Models;
/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
/// 
namespace QPC.BMS.Services
{


    public interface ISystemServices
    {
        /// <summary>
        /// Hàm khởi tạo cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        bool CreateDatabase();

        /// <summary>
        /// Ham ghi nhan loi duoc phat sinh ra tu ung dung vao trong database
        /// </summary>
        /// <param name="exception"> Lỗi từ hệ thống </param>
        /// <returns></returns>
        bool SetSystemExceptionLog(Exception exception, String url = null, String accountId = null);
    }
}

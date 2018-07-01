/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QPC.BMS.Domain.AutoMapper;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Models;
    using QPC.BMS.Repository;

    public class SystemServicesImp : BaseServices, ISystemServices
    {
        /// <summary>
        /// Hàm khởi tạo các đối tượng sử dụng cho class hiện tại
        /// </summary>
        public SystemServicesImp()
        {
            systemRepository = Repository.DependencyResolution.IoC.Container().GetInstance<ISystemRepository>(TargetImplement.V1.ToString());
        }

        /// <summary>
        /// Hàm khởi tạo cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        public bool CreateDatabase()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ghi log  vào database khi phát sinh lỗi trên hệ thống
        /// </summary>
        /// <param name="exception"> Biến ghi lỗi từ hệ thống </param>
        /// <param name="url"> URL phat sinh ra lỗi hệ thống </param>
        /// <param name="accountId"> Tài khoản thao tác hành động này </param>
        /// <returns></returns>
        public bool SetSystemExceptionLog(Exception exception, String url = null, String accountId = null)
        {
            /// Thực hiện khởi tạo đối tượng cho các biến String mang giá trị null
            /// 
            if (url == null) url = String.Empty;
            if (accountId == null) accountId = String.Empty;

            /// Khởi tạo một obj có kiêu dữ liệu model
            /// 
            SystemExceptionLogModel logModel = new SystemExceptionLogModel()
            {
                DateCreated = DateTime.Now,
                Message = exception.Message,
                Source = exception.Source,
                StackTrace = exception.StackTrace,
                TargetSite = exception.TargetSite != null ? exception.TargetSite.Name : "",
                Url = url,
                Username = accountId
            };

            /// Lưu dữ liệu vào Database
            /// 
            systemRepository.SetSystemExceptionLog(domainTier.SystemExceptionLogMapper.MappingModel2Entity(logModel));
            return true;
        }
    }
}

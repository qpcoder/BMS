/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using System;
    using System.Collections.Generic;
    using QPC.BMS.Repository.EF;
    using QPC.BMS.Repository.Enum;

    class SystemRepositoryImp : BaseRepository, ISystemRepository
    {
        public bool DeleteSetting(int settingID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSetting(Func<Setting, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSystemExceptionLog(int logID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSystemExceptionLog(Func<SystemExceptionLog, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditSetting(Func<Setting, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditSetting(Setting modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditSystemExceptionLog(Func<SystemExceptionLog, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditSystemExceptionLog(SystemExceptionLog modelEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SystemExceptionLog> GetAllLogs()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Setting> GetAllSettings()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Setting> GetSetting(Func<Setting, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Setting GetSetting(int settingID)
        {
            throw new NotImplementedException();
        }

        public Setting GetSystemExceptionLog(int logID)
        {
            throw new NotImplementedException();
        }

        public bool SetSetting(Setting models)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ghi nhân các lỗi phát sinh khi ứng dụng hoạt động
        /// </summary>
        /// <param name="models"> OBJ ghi nhân sự cố </param>
        /// <returns></returns>
        public bool SetSystemExceptionLog(SystemExceptionLog models)
        {
            /// Log enter method
            /// 
            logger.EnterMethod();

            try
            {
                db.SystemExceptionLogs.Add(models);
                db.SaveChanges();
                logger.Info(MessageReponsitory.INSERT_DATA_SUCCESSFUL);
                return true;
            }
            catch (Exception e)
            {
                logger.Warn(MessageReponsitory.INSERT_DATA_UNSUCCESSFUL);
                logger.Debug(MessageReponsitory.INSERT_DATA_UNSUCCESSFUL + e.Message);
                throw new Exception(MessageReponsitory.INSERT_DATA_UNSUCCESSFUL + e.Message);
            }
            finally
            {
                /// Log release method
                /// 
                logger.ReleaseMethod();
            }
        }

        public IEnumerable<SystemExceptionLog> SystemExceptionLog(Func<SystemExceptionLog, bool> expression)
        {
            throw new NotImplementedException();
        }
    }
}

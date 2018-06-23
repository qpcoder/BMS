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

    class SystemConfigurationRepositoryImp : ISystemConfigurationRepository
    {
        public bool CreateDatabase()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllLogs()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllSettings()
        {
            throw new NotImplementedException();
        }

        public bool DeleteDataDemo()
        {
            throw new NotImplementedException();
        }

        public bool DeleteLogByExpression(Func<SystemExceptionLog, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLogByID(Guid logID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSettingByExpression(Func<Setting, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSettingByID(Guid settingID)
        {
            throw new NotImplementedException();
        }

        public bool EditLogByExpression(Func<SystemExceptionLog, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditLogByObject(SystemExceptionLog modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditSettingByExpression(Func<Setting, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditSettingByObject(Setting modelEdit)
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

        public Setting GetLogByID(Guid logID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SystemExceptionLog> GetLogsByExpression(Func<SystemExceptionLog, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Setting GetSettingByID(Guid settingID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Setting> GetSettingsByExpression(Func<Setting, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool InsertDataCommon()
        {
            throw new NotImplementedException();
        }

        public bool InsertDataDemo()
        {
            throw new NotImplementedException();
        }

        public bool SetListLogs(List<SystemExceptionLog> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListSettings(List<Setting> models)
        {
            throw new NotImplementedException();
        }

        public bool SetLog(SystemExceptionLog models)
        {
            throw new NotImplementedException();
        }

        public bool SetSetting(Setting models)
        {
            throw new NotImplementedException();
        }
    }
}

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
            // check exists database

            // check version is new?

            // create if not exist database or version is old
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

        public bool DeleteLogByExpression(Func<Log, bool> expression)
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

        public bool EditLogByExpression(Func<Log, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditLogByObject(Log modelEdit)
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

        public IEnumerable<Log> GetAllLogs()
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

        public IEnumerable<Log> GetLogsByExpression(Func<Log, bool> expression)
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

        public bool SetListLogs(List<Log> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListSettings(List<Setting> models)
        {
            throw new NotImplementedException();
        }

        public bool SetLog(Log models)
        {
            throw new NotImplementedException();
        }

        public bool SetSetting(Setting models)
        {
            throw new NotImplementedException();
        }
    }
}

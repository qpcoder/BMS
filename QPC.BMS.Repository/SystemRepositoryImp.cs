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

    class SystemRepositoryImp : ISystemRepository
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

        public IEnumerable<SystemExceptionLog> SystemExceptionLogLog(Func<SystemExceptionLog, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool SystemExceptionLogLog(SystemExceptionLog models)
        {
            throw new NotImplementedException();
        }
    }
}

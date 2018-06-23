/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using QPC.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;

    public interface ISystemConfigurationRepository
    {
        #region Database Instance
        bool CreateDatabase();

        bool InsertDataCommon();

        bool InsertDataDemo();

        bool DeleteDataDemo();
        #endregion

        #region Table Setting

        /// <summary>
        /// Get all settings
        /// </summary>
        /// <returns>list settings</returns>
        IEnumerable<Setting> GetAllSettings();

        /// <summary>
        /// Gei setting by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list settings</returns>
        IEnumerable<Setting> GetSettingsByExpression(Func<Setting, bool> expression);

        /// <summary>
        /// Get setting by id
        /// </summary>
        /// <param name="settingID">setting id</param>
        /// <returns>object setting</returns>
        Setting GetSettingByID(Guid settingID);

        /// <summary>
        /// Insert list setting into database
        /// </summary>
        /// <param name="models">list settings</param>
        /// <returns>true or false</returns>
        Boolean SetListSettings(List<Setting> models);

        /// <summary>
        /// Insert object into database
        /// </summary>
        /// <param name="models">object setting</param>
        /// <returns>true or false</returns>
        Boolean SetSetting(Setting models);

        /// <summary>
        /// Update setting by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditSettingByExpression(Func<Setting, bool> expression);

        /// <summary>
        /// Update setting by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditSettingByObject(Setting modelEdit);

        /// <summary>
        /// Delete setting by ID
        /// </summary>
        /// <param name="logID">setting id</param>
        /// <returns>true or false</returns>
        Boolean DeleteSettingByID(Guid settingID);

        /// <summary>
        /// Delete setting by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteSettingByExpression(Func<Setting, bool> expression);

        /// <summary>
        /// Delete all settings
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllSettings();

        #endregion

        #region Table SystemExceptionLog

        /// <summary>
        /// Get all logs
        /// </summary>
        /// <returns>list logs</returns>
        IEnumerable<SystemExceptionLog> GetAllLogs();

        /// <summary>
        /// Gei SystemExceptionLog by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list logs</returns>
        IEnumerable<SystemExceptionLog> GetLogsByExpression(Func<SystemExceptionLog, bool> expression);

        /// <summary>
        /// Get SystemExceptionLog by id
        /// </summary>
        /// <param name="logID">SystemExceptionLog id</param>
        /// <returns>object SystemExceptionLog</returns>
        Setting GetLogByID(Guid logID);


        /// <summary>
        /// Insert list SystemExceptionLog into database
        /// </summary>
        /// <param name="models">list logs</param>
        /// <returns>true or false</returns>
        Boolean SetListLogs(List<SystemExceptionLog> models);

        /// <summary>
        /// Insert object into database
        /// </summary>
        /// <param name="models">object SystemExceptionLog</param>
        /// <returns>true or false</returns>
        Boolean SetLog(SystemExceptionLog models);

        /// <summary>
        /// Update SystemExceptionLog by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditLogByExpression(Func<SystemExceptionLog, bool> expression);

        /// <summary>
        /// Update SystemExceptionLog by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditLogByObject(SystemExceptionLog modelEdit);

        /// <summary>
        /// Delete SystemExceptionLog by ID
        /// </summary>
        /// <param name="logID">SystemExceptionLog id</param>
        /// <returns>true or false</returns>
        Boolean DeleteLogByID(Guid logID);

        /// <summary>
        /// Delete SystemExceptionLog by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteLogByExpression(Func<SystemExceptionLog, bool> expression);

        /// <summary>
        /// Delete all logs
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllLogs();

        #endregion

    }
}

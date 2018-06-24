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

    public interface ISystemRepository
    {
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
        IEnumerable<Setting> GetSetting(Func<Setting, bool> expression);

        /// <summary>
        /// Get setting by id
        /// </summary>
        /// <param name="settingID">setting id</param>
        /// <returns>object setting</returns>
        Setting GetSetting(int settingID);

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
        Boolean EditSetting(Func<Setting, bool> expression);

        /// <summary>
        /// Update setting by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditSetting(Setting modelEdit);

        /// <summary>
        /// Delete setting by ID
        /// </summary>
        /// <param name="logID">setting id</param>
        /// <returns>true or false</returns>
        Boolean DeleteSetting(int settingID);

        /// <summary>
        /// Delete setting by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteSetting(Func<Setting, bool> expression);

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
        IEnumerable<SystemExceptionLog> SystemExceptionLogLog(Func<SystemExceptionLog, bool> expression);

        /// <summary>
        /// Get SystemExceptionLog by id
        /// </summary>
        /// <param name="logID">SystemExceptionLog id</param>
        /// <returns>object SystemExceptionLog</returns>
        Setting GetSystemExceptionLog(int logID);

        /// <summary>
        /// Insert object into database
        /// </summary>
        /// <param name="models">object SystemExceptionLog</param>
        /// <returns>true or false</returns>
        Boolean SystemExceptionLogLog(SystemExceptionLog models);

        /// <summary>
        /// Update SystemExceptionLog by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditSystemExceptionLog(Func<SystemExceptionLog, bool> expression);

        /// <summary>
        /// Update SystemExceptionLog by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditSystemExceptionLog(SystemExceptionLog modelEdit);

        /// <summary>
        /// Delete SystemExceptionLog by ID
        /// </summary>
        /// <param name="logID">SystemExceptionLog id</param>
        /// <returns>true or false</returns>
        Boolean DeleteSystemExceptionLog(int logID);

        /// <summary>
        /// Delete SystemExceptionLog by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteSystemExceptionLog(Func<SystemExceptionLog, bool> expression);

        #endregion

    }
}

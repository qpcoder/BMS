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

    interface IDownloadRepository
    {
        #region Table Download

        /// <summary>
        /// Get all downloads
        /// </summary>
        /// <returns>list downloads</returns>
        IEnumerable<Download> GetAllDownloads();

        /// <summary>
        /// Get download by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list downloads</returns>
        IEnumerable<Download> GetDownloadsByExpression(Func<Download, bool> expression);

        /// <summary>
        /// Get download by id
        /// </summary>
        /// <param name="downloadID">download id</param>
        /// <returns>object download</returns>
        Download GetDownloadByID(Guid downloadID);

        /// <summary>
        /// Insert list download into database
        /// </summary>
        /// <param name="models">list downloads</param>
        /// <returns>true or false</returns>
        Boolean SetListDownloads(List<Download> models);

        /// <summary>
        /// Insert object into database
        /// </summary>
        /// <param name="models">object download</param>
        /// <returns>true or false</returns>
        Boolean SetDownload(Download models);

        /// <summary>
        /// Update download by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditDownloadByExpression(Func<Download, bool> expression);

        /// <summary>
        /// Update download by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditDownloadByObject(Download modelEdit);

        /// <summary>
        /// Delete download by ID
        /// </summary>
        /// <param name="downloadID">download id</param>
        /// <returns>true or false</returns>
        Boolean DeleteDownloadByID(Guid downloadID);

        /// <summary>
        /// Delete download by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteDownloadByExpression(Func<Download, bool> expression);

        /// <summary>
        /// Delete all downloads
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllDownloads();

        #endregion

    }
}

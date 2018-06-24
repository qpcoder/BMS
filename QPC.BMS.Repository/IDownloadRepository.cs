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
        IEnumerable<Download> GetDownload(Func<Download, bool> expression);

        /// <summary>
        /// Get download by id
        /// </summary>
        /// <param name="downloadID">download id</param>
        /// <returns>object download</returns>
        Download GetDownload(int downloadID);

        /// <summary>
        /// Insert list download into database
        /// </summary>
        /// <param name="models">list downloads</param>
        /// <returns>true or false</returns>
        Boolean SetDownload(List<Download> models);

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
        Boolean EditDownload(Func<Download, bool> expression);

        /// <summary>
        /// Update download by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditDownload(Download modelEdit);

        /// <summary>
        /// Delete download by ID
        /// </summary>
        /// <param name="downloadID">download id</param>
        /// <returns>true or false</returns>
        Boolean DeleteDownload(int downloadID);

        /// <summary>
        /// Delete download by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteDownload(Func<Download, bool> expression);

        #endregion

        #region Table DownloadTracking

        /// <summary>
        /// Get all download tracking
        /// </summary>
        /// <returns>list download tracking</returns>
        IEnumerable<DownloadTracking> GetAllDownloadTrackings();

        /// <summary>
        /// Get download tracking by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list downloads</returns>
        IEnumerable<DownloadTracking> GetDownloadTracking(Func<DownloadTracking, bool> expression);

        /// <summary>
        /// Get download tracking by id
        /// </summary>
        /// <param name="downloadID">download tracking id</param>
        /// <returns>object download</returns>
        DownloadTracking GetDownloadTracking(int downloadTrackingID);

        /// <summary>
        /// Insert list download tracking into database
        /// </summary>
        /// <param name="models">list download tracking</param>
        /// <returns>true or false</returns>
        Boolean SetDownloadTracking(List<DownloadTracking> models);

        /// <summary>
        /// Insert object into database
        /// </summary>
        /// <param name="models">object download tracking</param>
        /// <returns>true or false</returns>
        Boolean SetDownloadTracking(DownloadTracking models);

        /// <summary>
        /// Update download tracking by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditDownloadTracking(Func<DownloadTracking, bool> expression);

        /// <summary>
        /// Update download tracking by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditDownloadTracking(DownloadTracking modelEdit);

        /// <summary>
        /// Delete download tracking by ID
        /// </summary>
        /// <param name="downloadID">download tracking id</param>
        /// <returns>true or false</returns>
        Boolean DeleteDownloadTracking(int downloadID);

        /// <summary>
        /// Delete download tracking by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteDownloadTracking(Func<DownloadTracking, bool> expression);

        #endregion
    }
}

/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using QPC.BMS.Helpers;
using QPC.BMS.Helpers.Enum;
using QPC.BMS.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPC.BMS.Repository
{
    public class DownloadRepositoryImp : IDownloadRepository
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        private readonly ILoggingHelper logger;

        /// <summary>
        /// Handle instance for connect to database 
        /// </summary>
        private BMSContext db;

        public DownloadRepositoryImp()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());
            db = new BMSContext();
        }

        public bool DeleteDownload(int downloadID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDownload(Func<Download, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDownloadTracking(int downloadID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDownloadTracking(Func<DownloadTracking, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditDownload(Func<Download, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditDownload(Download modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditDownloadTracking(Func<DownloadTracking, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditDownloadTracking(DownloadTracking modelEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Download> GetAllDownloads()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DownloadTracking> GetAllDownloadTrackings()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Download> GetDownload(Func<Download, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Download GetDownload(int downloadID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DownloadTracking> GetDownloadTracking(Func<DownloadTracking, bool> expression)
        {
            throw new NotImplementedException();
        }

        public DownloadTracking GetDownloadTracking(int downloadTrackingID)
        {
            throw new NotImplementedException();
        }

        public bool SetDownload(List<Download> models)
        {
            throw new NotImplementedException();
        }

        public bool SetDownload(Download models)
        {
            throw new NotImplementedException();
        }

        public bool SetDownloadTracking(List<DownloadTracking> models)
        {
            throw new NotImplementedException();
        }

        public bool SetDownloadTracking(DownloadTracking models)
        {
            throw new NotImplementedException();
        }
    }
}

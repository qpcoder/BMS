/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QP.BMS.Repository.EF;

    public class DownloadRepositoryImp : IDownloadRepository
    {
        public DownloadRepositoryImp()
        {
        }

        public bool DeleteAllDownloads()
        {
            throw new NotImplementedException();
        }

        public bool DeleteDownloadByExpression(Func<Download, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDownloadByID(Guid downloadID)
        {
            throw new NotImplementedException();
        }

        public bool EditDownloadByExpression(Func<Download, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditDownloadByObject(Download modelEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Download> GetAllDownloads()
        {
            throw new NotImplementedException();
        }

        public Download GetDownloadByID(Guid downloadID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Download> GetDownloadsByExpression(Func<Download, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool SetDownload(Download models)
        {
            throw new NotImplementedException();
        }

        public bool SetListDownloads(List<Download> models)
        {
            throw new NotImplementedException();
        }
    }
}

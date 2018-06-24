/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QPC.BMS.Models;

    public interface ISystemServices
    {
        bool CreateDatabase();

        bool SetSystemExceptionLog(SystemExceptionLogModel logModel);
    }
}

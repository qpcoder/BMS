/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPC.BMS.Helpers
{
    public interface IEncryptHelper
    {
        /// <summary>
        /// Ma hoa chuoi
        /// </summary>
        /// <param name="sString"></param>
        /// <returns></returns>
        string Encrypt(string sString);

        /// <summary>
        /// Giai ma chuoi
        /// </summary>
        /// <param name="sString"></param>
        /// <returns></returns>
        string Decrypt(string sString);
    }
}

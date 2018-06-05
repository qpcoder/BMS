/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QP.BMS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DownloadDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required]
        public Guid ID { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string FileName { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int FileSize { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateUpload { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? AccountID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual AccountDTO Account { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int DownlaodCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string LinkDownload { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean Status { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<AccountDTO> Accounts { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<UniversityDTO> Universities { set; get; }
    }
}

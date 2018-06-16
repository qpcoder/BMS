/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Download
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
        public DateTime? DateUpload { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? AccountID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Account Account { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(0)]
        public int DownlaodCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string LinkDownload { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? Status { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Account> Accounts { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<University> Universities { set; get; }
    }
}
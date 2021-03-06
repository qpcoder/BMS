﻿/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DownloadModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string FileName { set; get; }

        public float FileSize { set; get; }

        public DateTime? DateUpload { set; get; }

        public int AccountID { set; get; }
        public virtual AccountModel Account { set; get; }

        /// <summary>
        /// Tong so luot tai cho lien ket hien tai
        /// </summary>
        public int TotalClick { set; get; }

        public string LinkDownload { set; get; }

        public Boolean Status { set; get; }


        public virtual IEquatable<DownloadTrackingModel> DownloadTrackings{ set; get; }
     }
}
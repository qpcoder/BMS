/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Download
    {
        [Key]
        [Required]
        public int ID { set; get; }

        public string FileName { set; get; }

        public float FileSize { set; get; }

        public DateTime? DateUpload { set; get; }

        public int AccountID { set; get; }
        public virtual Account Account { set; get; }

        public int TotalClick { set; get; }

        public string LinkDownload { set; get; }

        public string IPAddress { set; get; }

        public Boolean Status { set; get; }
    }
}
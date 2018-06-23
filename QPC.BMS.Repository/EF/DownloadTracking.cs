/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DownloadTracking
    {
    [Key]
    [Required]
        public int ID { set; get; }
        
        public int DownloadID { set; get; }
        public virtual Download Download { set; get; }

        public int AccountID { set; get; }
        public virtual Account Account { set; get; }

        public string IPAddress { set; get; }
        
        public string WebBrower { set; get; }
        
        public DateTime? DateTracking { set; get; }
    }
}
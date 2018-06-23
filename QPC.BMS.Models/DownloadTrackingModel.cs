/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DownloadTrackingModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int DownloadID { set; get; }
        public virtual DownloadModel Download { set; get; }

        /// <summary>
        /// Cho phep khach vang lai tai tai lieu. 
        /// Neu la user cua he thong thi ghi nhan lai thong tin nguoi do.
        /// </summary>
        public int AccountID { set; get; }

        /// <summary>
        /// IP cua nguoi thuc hien tai tai lieu.
        /// </summary>
        public string IPAddress { set; get; }

        /// <summary>
        /// Trinh duyet ma nguoi dung thuc hien hanh dong tai tai lieu.
        /// </summary>
        public string WebBrower { set; get; }

        public DateTime? DateTracking { set; get; }
    }
}
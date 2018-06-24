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
    using System.Reflection;

    public class SystemExceptionLogModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        /// <summary>
        /// User thuc hien va tao ra loi
        /// </summary>
        public string Username { set; get; }

        public DateTime? DateCreated { set; get; }

        /// <summary>
        /// Thong diep cua loi
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// Duong dan chi tiet den cai loi do
        /// </summary>
        public string StackTrace { set; get; }

        /// <summary>
        /// Nguon goc phat sinh ra exeption
        /// </summary>
        public string Source { set; get; }

        /// <summary>
        /// Duong dan URL luc do
        /// </summary>
        public string Url { set; get; }


        public string TargetSite { get; set; }
    }
}
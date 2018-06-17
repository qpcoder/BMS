/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.ComponentModel.DataAnnotations;

namespace QPC.BMS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageDTO
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
        public Guid? AccountID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public AccountDTO Account { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Alt { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Permalink { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int ImageSize { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean IsAvatar { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean IsBackground { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean IsFeaturedPost { set; get; }
    }
}
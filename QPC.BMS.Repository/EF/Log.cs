/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Log
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
        public DateTime? Date { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Thread { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Level { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Logger { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Exceptions { set; get; }
    }
}
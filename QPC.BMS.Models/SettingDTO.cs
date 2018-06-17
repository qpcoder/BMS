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

namespace QPC.BMS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SettingDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required]
        public int ID { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Value { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean AutoLoad { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateUpdated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean Status { set; get; }

    }
}

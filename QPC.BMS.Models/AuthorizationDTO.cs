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
    public class AuthorizationDTO
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
        public int? RoleID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual RoleDTO Role { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? ModuleID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ModuleDTO Module { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean AuView { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean AuInsert { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean AuUpdate { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean AuDelete { set; get; }

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

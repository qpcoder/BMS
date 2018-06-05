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

namespace QP.BMS.Repository.EF
{
    /// <summary>
    /// 
    /// </summary>
    public class Authorization
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
        public Guid? RoleID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Role Role { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ModuleID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Module Module { set; get; }

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

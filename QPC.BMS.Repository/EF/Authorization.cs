/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPC.BMS.Repository.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Authorization
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? RoleID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Role Role { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? ModuleID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Module Module { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? AuView { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? AuInsert { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? AuUpdate { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? AuDelete { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateUpdated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? Status { set; get; }
    }
}

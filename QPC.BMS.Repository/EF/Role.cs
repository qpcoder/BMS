/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Role
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
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? Status { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEquatable<Authorization> Authorizations { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEquatable<Account> Accounts { set; get; }
    }
}
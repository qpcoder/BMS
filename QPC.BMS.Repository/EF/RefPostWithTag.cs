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

    public class RefPostWithTag
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
        public Guid? TagID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Tag Tag { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? PostID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Post Post { set; get; }

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
        public Boolean? Satus { set; get; }
    }
}
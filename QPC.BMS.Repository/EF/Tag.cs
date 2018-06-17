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

    public class Tag
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
        public virtual Account Account { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Permalink { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Excerpt { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { set; get; }

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
        [DefaultValue(0)]
        public int PostCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(0)]
        public Boolean? Status { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<RefPostWithTag> RefPostWithTags { set; get; }
    }
}
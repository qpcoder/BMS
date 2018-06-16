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

    public class Post
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
        public Guid? PostTypeID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual PostType PostType { set; get; }

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
        public string Title { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Excerpt { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Permalink { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Content { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ImageID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Image Image { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? Status { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? AllowComments { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(0)]
        public int CommentCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string MetaTitle { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string MetaKeywords { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string MetaDescription { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Image> Images { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Comment> Comments { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<RefPostWithTag> RefPostWithTags { set; get; }
    }
}
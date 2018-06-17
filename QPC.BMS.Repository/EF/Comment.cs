/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Comment
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
        public Guid? PostID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Post Post { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Content { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Approved { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string IPAddress { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Agent { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CommentParentID { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Comment> Comments { set; get; }
    }
}
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

namespace QP.BMS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class PostDTO
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
        public virtual AccountDTO Account { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? PostTypeID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual PostTypeDTO PostType { set; get; }

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
        public virtual ImageDTO Image { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean Status { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean AllowComments { set; get; }

        /// <summary>
        /// 
        /// </summary>
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
        public virtual IEnumerable<ImageDTO> Images { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<CommentDTO> Comments { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<RefPostWithTagDTO> RefPostWithTags { set; get; }
    }
}

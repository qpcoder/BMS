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
    public class CommentDTO
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
        public Guid? PostID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual PostDTO Post { set; get; }

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
        public virtual IEnumerable<CommentDTO> Comments { set; get; }
    }
}

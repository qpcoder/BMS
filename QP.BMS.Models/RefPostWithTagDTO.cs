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
    public class RefPostWithTagDTO
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
        public virtual TagDTO Tag { set; get; }

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
        public DateTime DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateUpdated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean Satus { set; get; }
    }
}

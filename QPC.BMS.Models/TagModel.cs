/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class TagModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        /// <summary>
        /// Author tao ra tag nay.
        /// </summary>
        public int AccountID { set; get; }
        public virtual AccountModel Account { set; get; }

        public string Name { set; get; }

        public string Permalink { set; get; }

        public string Excerpt { set; get; }

        public string Description { set; get; }

        public string DateCreate { set; get; }

        public string DateUpdate { set; get; }

        /// <summary>
        /// Tong so bai viet cua Tag nay
        /// </summary>
        public int PostCount { set; get; }

        public string Status { set; get; }


        public virtual IEquatable<RefPostWithTagModel> RefPostWithTags { set; get; }
    }
}
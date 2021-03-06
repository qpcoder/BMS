﻿/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AuthorPostModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int AccountID { set; get; }

        /// <summary>
        /// Cho phep author nay tao ra tag moi hay khong.
        /// mac dinh la false
        /// </summary>
        [DefaultValue(false)]
        public Boolean? AllowTag { set; get; }

        /// <summary>
        /// Cho phep author nay tao ra series moi khong.
        /// Mac dinh la false.
        /// </summary>
        [DefaultValue(false)]
        public Boolean? AllowSeries { set; get; }

        public DateTime? DateCreate { set; get; }

        public Boolean Status { set; get; }



        public virtual IEquatable<PostModel> Posts { set; get; }
    }
}
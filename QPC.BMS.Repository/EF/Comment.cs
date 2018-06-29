/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Comment
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        /// <summary>
        /// Cho phep null
        /// </summary>
        public int AccountID { set; get; }

        public int PostID { set; get; }

        public string Content { set; get; }

        /// <summary>
        /// Nguoi doc thich binh luan nay
        /// </summary>
        public int UpVote { set; get; }

        /// <summary>
        /// Nguoi doc khong thich binh luan nay
        /// </summary>
        public int DownVote { set; get; }

        /// <summary>
        /// IP nguoi dung thuc hien binh luan
        /// </summary>
        public string IPAddress { set; get; }

        /// <summary>
        /// Binh luan cha cua binh luan nay
        /// </summary>
        public int CommentParentID { set; get; }

        public DateTime? DateCreate { set; get; }

        public Boolean Status { set; get; }
    }
}
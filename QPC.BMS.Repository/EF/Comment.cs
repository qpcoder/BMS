/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        [Key]
        [Required]
        public int ID { set; get; }

        public int AccountID { set; get; }
        public virtual Account Account { set; get; }

        public int PostID { set; get; }
        public virtual Post Post { set; get; }

        public string Content { set; get; }

        public int UpVote { set; get; }

        public int DownVote { set; get; }

        public string IPAddress { set; get; }

        public int CommentParentID { set; get; }

        public DateTime DateCreate { set; get; }

        public Boolean Status { set; get; }
    }
}
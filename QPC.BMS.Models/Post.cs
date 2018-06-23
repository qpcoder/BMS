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

    public class Post
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        
        public int AccountID { set; get; }

        public int PostTypeID { set; get; }
        public virtual PostType PostType{ set; get; }
        
        public DateTime? DateCreate { set; get; }
        
        public DateTime? DateUpdate { set; get; }
        
        public string Title { set; get; }
        
        public string Excerpt { set; get; }
        
        public string Permalink { set; get; }
        
        public string Content { set; get; }
        
        public int FeaturedImageID { set; get; }
        public virtual Media Media { set; get; }
   
        public Boolean? AllowComment { set; get; }
        
        public int CommentTotal { set; get; }

        public int StarLevel { set; get; }
        
        public int UpVote { set; get; }
        
        public int DownVote { set; get; }

        public Boolean Status { set; get; }
    }
}
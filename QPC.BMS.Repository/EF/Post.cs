/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel;
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
        
        public DateTime? DateCreate { set; get; }
        
        public DateTime? DateUpdate { set; get; }
        
        public string Title { set; get; }
        
        public string Excerpt { set; get; }
        
        public string Permalink { set; get; }
        
        public string Content { set; get; }
        
        public int FeaturedImageID { set; get; }
   
        public Boolean? AllowComment { set; get; }
        
        /// <summary>
        /// Tong so binh luan
        /// </summary>
        public int CommentTotal { set; get; }

        /// <summary>
        /// Mac dinh bagn 0.
        /// Set nguoi dung dat bao nhieu sao thi moi co quen xem noi dung bai viet nay.
        /// </summary>
        [DefaultValue(0)]
        public int StarLevel { set; get; }
        
        /// <summary>
        /// So nguoi dung thich
        /// </summary>
        public int UpVote { set; get; }
        
        /// <summary>
        /// Nguoi dung khong thich
        /// </summary>
        public int DownVote { set; get; }

        /// <summary>
        /// Tac gia cua bai dang
        /// </summary>
        public int AuthorPostID { set; get; }

        public Boolean Status { set; get; }

    }
}
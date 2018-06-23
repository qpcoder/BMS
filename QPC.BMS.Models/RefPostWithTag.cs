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

    public class RefPostWithTag
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int TagID { set; get; }
        public Tag Tag { set; get; }

        public int PostID { set; get; }
        public virtual Post Post { set; get; }

        public DateTime? DateCreate { set; get; }

        public DateTime? DateUpdate { set; get; }

        public Boolean Satus { set; get; }
    }
}
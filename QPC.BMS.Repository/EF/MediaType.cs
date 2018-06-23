/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class MediaType
    {
        [Key]
        [Required]
        public int ID { set; get; }

        public string TypeName { set; get; }

        public string TypeExtention { set; get; }

        public DateTime? DateCreate { set; get; }

        public Boolean Status { set; get; }
    }
}
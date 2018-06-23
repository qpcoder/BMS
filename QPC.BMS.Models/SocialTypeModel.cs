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

    public class SocialTypeModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }

        public string Name { set; get; }

        public DateTime? DateCreate { set; get; }

        public Boolean Status { set; get; }


        public virtual IEquatable<SocialApiModel> SocialApi { set; get; }
    }
}
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

    public class MediaTypeModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string TypeName { set; get; }

        public string TypeExtention { set; get; }

        public DateTime? DateCreate { set; get; }

        public Boolean Status { set; get; }


        public virtual IEquatable<MediaModel> Medias{ set; get; }
    }
}
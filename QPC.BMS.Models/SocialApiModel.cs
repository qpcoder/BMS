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

    public class SocialApiModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int SocialTypeID { set; get; }
        public virtual SocialTypeModel SocialType { set; get; }

        public int AccountID { set; get; }
        public virtual AccountModel Account { set; get; }

        /// <summary>
        /// Ten goi Api cho mang do dang dung
        /// </summary>
        public string ApiKey { set; get; }

        /// <summary>
        /// Gia tri cho api Key do
        /// </summary>
        public string ApiValue { set; get; }

        public DateTime? DateCreate { set; get; }

        public string Status { set; get; }
    }
}
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

    public class SocialApi
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int SocialTypeID { set; get; }

        public int AccountID { set; get; }

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
/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SocialApi
    {
        [Key]
        [Required]
        public int ID { set; get; }

        public int SocialTypeID { set; get; }
        public virtual SocialType SocialType { set; get; }

        public int AccountJD { set; get; }
        public virtual Account Account { set; get; }

        public string ApiKey { set; get; }

        public string SecrectKey { set; get; }

        public DateTime? DateCreate { set; get; }

        public string Status { set; get; }
    }
}
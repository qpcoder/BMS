/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ApiAuthorize
    {
        [Key]
        [Required]
        public int ID { set; get; }

        public int AccountID { set; get; }
        public virtual Account Account { set; get; }

        public DateTime? DateCreate { set; get; }

        public Boolean? IsActive { set; get; }

        public string Apikey { set; get; }

        public string SecretKey { set; get; }

        public DateTime? DateModified { set; get; }

        public string IsEnableUrl { set; get; }

        public int AccountIDUpdate { set; get; }

        public DateTime DateUpdate { set; get; }
    }
}
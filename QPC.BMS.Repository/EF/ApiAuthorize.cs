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

    public class ApiAuthorize
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int AccountID { set; get; }
        public virtual Account Account { set; get; }

        public DateTime? DateCreate { set; get; }

        /// <summary>
        /// Mac dinh: API cua tai khan se bi vo hieu hoa
        /// </summary>
        [DefaultValue(false)]
        public Boolean? IsActive { set; get; }

        public string Apikey { set; get; }

        public string SecretKey { set; get; }

        public DateTime? DateModified { set; get; }
    }
}
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

    public class Province
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int CountryID { set; get; }
        public virtual Country Country { set; get; }

        /// <summary>
        /// ma tinh thanh
        /// </summary>
        public int Code { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        public DateTime? DateCreated { set; get; }

        public DateTime? DateUpdated { set; get; }

        public Boolean Status { set; get; }


        public virtual IEquatable<District> Districts{ set; get; }
    }
}
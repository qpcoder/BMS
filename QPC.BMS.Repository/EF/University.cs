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

    public class University
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? DistrictID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual District District { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Fax { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Website { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateUpdated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? Status { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEquatable<Faculties> Faculties { set; get; }
    }
}
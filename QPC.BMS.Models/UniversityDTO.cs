/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.ComponentModel.DataAnnotations;

namespace QPC.BMS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UniversityDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required]
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
        public virtual DistrictDTO District { set; get; }

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
        public DateTime DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateUpdated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean Status { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEquatable<FacultiesDTO> Faculties { set; get; }
    }
}
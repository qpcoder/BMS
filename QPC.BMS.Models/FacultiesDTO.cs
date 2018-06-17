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
    public class FacultiesDTO
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
        public string Code { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? UniversityID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual UniversityDTO University { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { set; get; }

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
        public virtual IEquatable<GraderDTO> Graders { set; get; }
    }
}
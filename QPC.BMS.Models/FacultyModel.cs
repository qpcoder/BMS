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

    public class FacultyModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        /// <summary>
        /// Ma cua khoa
        /// </summary>
        public string Code { set; get; }

        public int UniversityID { set; get; }
        public virtual UniversityModel University { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        public DateTime? DateCreate { set; get; }

        public DateTime? DateUpdate { set; get; }

        public Boolean Status { set; get; }


        public virtual IEquatable<GraderModel> Graders{ set; get; }
    }
}
﻿/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Grader
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        /// <summary>
        /// Ma lop
        /// </summary>
        public string Code { set; get; }

        public string Name { set; get; }

        public int FacultyID { set; get; }
        public virtual Faculty Faculty { set; get; }

        public string Description { set; get; }

        public DateTime? DateCreate { set; get; }

        public DateTime? DateUpdate { set; get; }

        public string Status { set; get; }


        public virtual IEquatable<Student> Students{ set; get; }
    }
}
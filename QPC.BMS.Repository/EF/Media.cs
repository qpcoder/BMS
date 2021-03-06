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

    public class Media
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }

        public int MediaTypeID { set; get; }

        public int AccountID { set; get; }

        public string FileName { set; get; }

        public string Alt { set; get; }

        public string Permalink { set; get; }

        public DateTime DateCreated { set; get; }

        public float FileSize { set; get; }
    }
}
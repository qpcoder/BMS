﻿/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class RoleModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Name { set; get; }

        public string Description { set; get; }

        /// <summary>
        /// Tong so tanh vien duoc phan cho quen nay
        /// </summary>
        public string TotalMember { set; get; }

        public DateTime DateCreate { set; get; }

        public string Status { set; get; }


        public virtual IEquatable<AuthorizationModel> Authorizations { set; get; }

        public virtual IEquatable<AccountModel> Accounts { set; get; }
    }
}
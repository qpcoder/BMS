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

    public class University
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Name { set; get; }

        public string Address { set; get; }

        public int DistrictID { set; get; }
        public virtual District District { set; get; }

        public string Fax { set; get; }

        public string Phone { set; get; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Email is invalid!")]
        public string Email { set; get; }

        public string Website { set; get; }

        public DateTime? DateCreate { set; get; }

        public DateTime? DateUpdate { set; get; }

        public Boolean Status { set; get; }


        public virtual IEquatable<Faculty> Faculties { set; get; }
    }
}
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

    public class AuditingLog
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string LoginName { set; get; }

        public string ComputerName { set; get; }

        public string ComputerIP { set; get; }

        public int MiduleID { set; get; }
        public virtual Module Module { set; get; }

        public DateTime? DateCreate { set; get; }

        public string ActionName { set; get; }

        public string Description { set; get; }

        public string ActionURL { set; get; }

        public int AccountID { set; get; }
        public virtual Account Account { set; get; }
    }
}
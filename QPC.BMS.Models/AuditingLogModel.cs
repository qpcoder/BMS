/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Models
{
    using QPC.BMS.Helpers.Enum;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AuditingLogModel
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string LoginName { set; get; }

        /// <summary>
        /// Ten may tinh ma user su dung de thao tac tren he thong
        /// </summary>
        public string ComputerName { set; get; }

        /// <summary>
        /// IP cua may tinh do
        /// </summary>
        public string ComputerIP { set; get; }

        /// <summary>
        /// User dang thao tac tai module nao
        /// </summary>
        public int MiduleID { set; get; }
        public virtual ModuleModel Module { set; get; }

        /// <summary>
        /// Thoi gian thuc hien hanh dong
        /// </summary>
        public DateTime? DateCreate { set; get; }

        /// <summary>
        /// Hanh dong do la gi
        /// </summary>
        public ActionName ActionName { set; get; }

        public string Description { set; get; }

        /// <summary>
        /// Duong dan cu the la nhu the nao
        /// </summary>
        public string ActionURL { set; get; }
    }
}
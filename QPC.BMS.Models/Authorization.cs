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

    public class Authorization
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        
        public int RoleID { set; get; }
        public virtual Role Role{ set; get; }
        
        public int ModuleID { set; get; }
        public virtual Module Module{ set; get; }
        
        public Boolean? AuView { set; get; }
        
        public Boolean? AuInsert { set; get; }
        
        public Boolean? AuUpdate { set; get; }
        
        public Boolean? AuDelete { set; get; }
        
        public DateTime? DateCreate { set; get; }
        
        public DateTime? DateUpdate { set; get; }
        
        public Boolean Status { set; get; }
    }
}
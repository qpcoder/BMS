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

    public class Module
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        
        public string Name { set; get; }
        
        public string ModuleURL { set; get; }
        
        public string Description { set; get; }
        
        public DateTime? DateCreate { set; get; }
        
        public Boolean Status { set; get; }

    }
}
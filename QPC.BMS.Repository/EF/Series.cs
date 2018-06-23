/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Series
    {
    [Key]
    [Required]
        public int ID { set; get; }
        
        public int AccountID { set; get; }
        public virtual Account Account { set; get; }

        public string Name { set; get; }
        
        public string Code { set; get; }
        
        public string Permalink { set; get; }
        
        public string Excerpt { set; get; }
        
        public string Description { set; get; }
        
        public DateTime? DateCreate { set; get; }
        
        public DateTime? DateUpdate { set; get; }
        
        public int PostCount { set; get; }
        
        public Boolean Status { set; get; }
    }
}
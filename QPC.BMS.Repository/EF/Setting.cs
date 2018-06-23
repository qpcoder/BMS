/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Setting
    {
    [Key]
    [Required]
        public int ID { set; get; }

        public string Key { set; get; }

        
        public string Value { set; get; }
        
        public Boolean? IsAutoLoad { set; get; }
        public DateTime? DateCreate { set; get; }
        public DateTime? DateUpdate { set; get; }
        public Boolean Status { set; get; }
    }
}
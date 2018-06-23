/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System.ComponentModel.DataAnnotations;

    public class Tag
    {
    [Key]
    [Required]
        public int ID { set; get; }
        
        public int AccountID { set; get; }
        public virtual Account Account{ set; get; }

        public string Name { set; get; }

        
        public string Permalink { set; get; }
        
        public string Excerpt { set; get; }
        
        public string Description { set; get; }
        
        public string DateCreate { set; get; }

        public string DateUpdate { set; get; }

        public int PostCount { set; get; }
        
        public string Status { set; get; }
    }
}
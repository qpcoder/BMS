/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SystemExceptionLog
    {
        [Key]
        [Required]
        public int Id { set; get; }

        public string Username { set; get; }

        public DateTime? DateCreated { set; get; }

        public string Message { set; get; }

        public string StackTrace { set; get; }

        public string Source { set; get; }

        public string Url { set; get; }
    }
}
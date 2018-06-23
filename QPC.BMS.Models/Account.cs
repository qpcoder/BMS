/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using QPC.BMS.Helpers.Enum;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Account
    {
        [Key]
        [Required]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string UserName { set; get; }
        
        public string Password { set; get; }
        
        public string FirstName { set; get; }
        
        public string LastName { set; get; }
        
        public string DisplayName { set; get; }
        
        public string Permalink { set; get; }
        
        public Gender? Gender { set; get; }
        
        public DateTime BirthDay { set; get; }
        
        public string Address { set; get; }

        public int DistrictID { set; get; }
        public virtual District District{ set; get; }

        public int GraderID { set; get; }
        public virtual Grader Grader{ set; get; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Email is invalid!")]
        public string Email { set; get; }
        
        public string Phone { set; get; }
        
        public int StarLevel { set; get; }
        
        public int TotalPoint { set; get; }
        
        public int TotalVote { set; get; }
        
        public string Website { set; get; }
        
        public string FaceBook { set; get; }
        
        public string Twitter { set; get; }
        
        public string Zalo { set; get; }
        
        public string Youtube { set; get; }
        
        public string Evernote { set; get; }
        
        public string GooglePlus { set; get; }
        
        public string Linkedin { set; get; }
        
        public string Instagram { set; get; }
        
        public string Flickr { set; get; }
        
        public DateTime? DateCreate { set; get; }
        
        public DateTime? DateUpdate { set; get; }
        
        public int RoleID { set; get; }
        public virtual Role Role { set; get; }
        
        public int TotalPost { set; get; }
        
        public int TotalComment { set; get; }
        
        public string MSSV { set; get; }
        
        public string Specialized { set; get; }
        
        public string GraduationYear { set; get; }
        
        public DateTime LastLoginDate { set; get; }
        
        public string AvatarPath { set; get; }
        
        public AccountStatus Status { set; get; }
    }
}
/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QPC.BMS.Repository.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Account
    {
        /// <summary>
        /// 
        /// </summary>
        [Key]
        [Required]
        public Guid ID { set; get; }

        /// <summary>
        /// Username login to system
        /// </summary>
        [Required]
        public string UserName { set; get; }

        /// <summary>
        /// Password login to system
        /// </summary>
        [Required]
        public string Password { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string MiddleName { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string NickName { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string DisplayNamePublic { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Gender { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? GraderID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual Grader Grader { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string MSSV { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Specialized { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? GraduationYear { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? BirthDay { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Phone { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Website { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string FaceBook { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Twitter { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Zalo { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Youtube { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Evernote { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string GooglePlus { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Linkedin { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Instagram { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Flickr { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public string Permalink { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? DateUpdated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? IsStudent { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int? RoleID { set; get; }
        /// <summary>
        /// Handle object role
        /// </summary>
        public virtual Role Role { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? IsActivitied { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(0)]
        public int? PostCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(0)]
        public int? CommentCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public Boolean? Status { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Series> Series { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Tag> Tags { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Account> Accounts { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Comment> Comments { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Post> Posts { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Image> Images { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<Download> Downloads { set; get; }
    }
}

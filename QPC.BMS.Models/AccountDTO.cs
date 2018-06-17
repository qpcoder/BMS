/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using QPC.BMS.Helpers.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QPC.BMS.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class AccountDTO
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
        public Gender Gender { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? GraderID { set; get; }
        /// <summary>
        /// 
        /// </summary>
        public virtual GraderDTO Grader { set; get; }

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
        public DateTime GraduationYear { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime BirthDay { set; get; }

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
        public DateTime DateCreated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateUpdated { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public Boolean IsStudent { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int RoleID { set; get; }
        /// <summary>
        /// Handle object role
        /// </summary>
        public virtual RoleDTO Role { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int PostCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public int CommentCount { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public AccountStatus? Status { set; get; }


        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<SeriesDTO> Series { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<TagDTO> Tags { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<AccountDTO> Accounts { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<CommentDTO> Comments { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<PostDTO> Posts { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<ImageDTO> Images { set; get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEnumerable<DownloadDTO> Downloads { set; get; }
    }
}

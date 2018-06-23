/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using QPC.BMS.Helpers.Enum;
    using System;
    using System.ComponentModel;
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

        /// <summary>
        /// Cho phep Null.
        /// Neu nguoi do hong phai la sinh vien
        /// </summary>
        public int GraderID { set; get; }
        public virtual Grader Grader{ set; get; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Email is invalid!")]
        public string Email { set; get; }
        
        public string Phone { set; get; }
        
        /// <summary>
        /// Cap sao cua tai khoan.
        /// Mac dinh bang 0.
        /// Khi tong diem dat 500 thi tang len 1 sao.
        /// </summary>
        [DefaultValue(0)]
        public int StarLevel { set; get; }

        /// <summary>
        /// Tong dien cua tai khoan nay.
        /// Khi dat tong 300 vote thi tang 1 diem.
        /// Share bai viet len cac kenh mang xa hoi duoc cong 1 diem.
        /// </summary>
        [DefaultValue(0)]
        public int TotalPoint { set; get; }

        /// <summary>
        /// Bai dang hoac binh luan cua se duoc thanh vien khac vote.
        /// Tong cua tat ca cac hieu so vote o cac bai dang, cac comment
        /// </summary>
        [DefaultValue(0)]
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

        /// <summary>
        /// Mac dinh bang 0
        /// Neu la Author dang bai thi cot nay se khac o.
        /// Luu record phan quyen author cho tai khoa nay.
        /// </summary>
        [DefaultValue(0)]
        public int AuthorPostID { set; get; }

        /// <summary>
        /// Tong so bai dang cua tai khoan nay
        /// </summary>
        public int TotalPost { set; get; }

        /// <summary>
        /// Tong so binh luan cua tai khoan nay
        /// </summary>
        public int TotalComment { set; get; }
        
        public string MSSV { set; get; }
        
        public string Specialized { set; get; }
        
        public string GraduationYear { set; get; }
        
        /// <summary>
        /// Lan dang nhap cuoi cung cua account nay
        /// </summary>
        public DateTime LastLoginDate { set; get; }
        
        public string AvatarPath { set; get; }

        /// <summary>
        /// Neu tai khoan khong co nguoi quan ly thi de null
        /// Tai khoan duoc quan ly boi tai khoan nao.
        /// </summary>
        public int AccountParentID{ set; get; }

        public AccountStatus Status { set; get; }


        //cac kien ket nhieu tu ban account
        public virtual IEquatable<Media> Medias { set; get; }

        public virtual IEquatable<Comment> Comments { get; set; }

        public virtual IEquatable<SocialApi> SocialApis { get; set; }
    }
}
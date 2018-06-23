/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        [Key]
        public int ID { set; get; }

        /// <summary>
        /// Cho phep Null.
        /// Neu nguoi do hong phai la sinh vien
        /// </summary>
        public int GraderID { set; get; }
        public virtual Grader Grader { set; get; }
       
        public string MSSV { set; get; }

        public string Specialized { set; get; }

        public string GraduationYear { set; get; }

    }
}
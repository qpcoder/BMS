/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QP.BMS.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using QP.BMS.Repository.EF;

    internal sealed class Configuration : DbMigrationsConfiguration<QP.BMS.Repository.EF.BMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BMSContext context)
        {
            #region Insert table account
            context.Accounts.Add(new Account() {
                ID = Guid.Parse(""),
                UserName = "admin",
                Password = "admin",
                FirstName = "Nguyen",
                MiddleName = "Huu",
                LastName = "Quy",
                BirthDay = DateTime.Today,
                Email = "qpcoders@gmail.com",
                DisplayNamePublic = "Administrator",
                FaceBook = "nguyen.quy.0710",
                Twitter = "devnguyenquy",
                Gender = "Male",
                NickName = "qpCoders",
                Address = "600/1 Quang Trung",
                Phone = "0974691005",
                IsActivitied = true,
                Website = "www.qpcoders.com",
                Status = true
            });
            context.SaveChanges();
            #endregion

            base.Seed(context);
        }
    }
}

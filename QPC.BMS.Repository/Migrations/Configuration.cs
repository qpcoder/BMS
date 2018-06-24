/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using QPC.BMS.Repository.EF;

    internal sealed class Configuration : DbMigrationsConfiguration<QPC.BMS.Repository.EF.BMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BMSContext context)
        {
            base.Seed(context);
            
            ///  This method will be called after migrating to the latest version.
            ///  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            ///  to avoid creating duplicate seed data.
        }
    }
}

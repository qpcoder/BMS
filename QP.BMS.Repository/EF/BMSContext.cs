/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QP.BMS.Repository.EF
{
    /// <summary>
    /// 
    /// </summary>
    public class BMSContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public BMSContext() : base("name=BMSContext")
        {
            Database.SetInitializer<BMSContext>(
                new DropCreateDatabaseIfModelChanges<BMSContext>());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        #region Declare instance models
        public DbSet<Account> Accounts { set; get; }
        public DbSet<Authorization> Authorizations { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Download> Downloads { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Grader> Graders { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<RefPostWithTag> RefPostWithTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<University> Universities { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

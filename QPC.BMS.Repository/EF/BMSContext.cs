/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.EF
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;


    /// <summary>
    /// 
    /// </summary>
    public class BMSContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public BMSContext():base("name=BMSContext")
        {
            Database.SetInitializer<BMSContext>(new DropCreateDatabaseIfModelChanges<BMSContext>());
        }

        /// <summary>
        /// Ham luu xuong database theo co che dong bo
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        /// <summary>
        /// Ham luu xuong database theo co che bat dong bo
        /// </summary>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        #region Declare instance models
        public DbSet<Account> Accounts { set; get; }
        public DbSet<ApiAuthorize> ApiAuthorizes { set; get; }
        public DbSet<AuditingLog> AuditingLogs { set; get; }
        public DbSet<AuthorPost> AuthorPosts { set; get; }
        public DbSet<Authorization> Authorizations { set; get; }
        public DbSet<Comment> Comments { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<District> Districts { set; get; }
        public DbSet<Download> Downloads { set; get; }
        public DbSet<DownloadTracking> DownloadTrackings { set; get; }
        public DbSet<Faculty> Faculties { set; get; }
        public DbSet<Grader> Graders { set; get; }
        public DbSet<Media> Medias { set; get; }
        public DbSet<MediaType> MediaTypes { set; get; }
        public DbSet<Module> Modules { set; get; }
        public DbSet<NavigationMenu> NavigationMenus { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostType> PostTypes { set; get; }
        public DbSet<Province> Provinces { set; get; }
        public DbSet<RefPostWithTag> RefPostWithTags { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<Series> Series { set; get; }
        public DbSet<Setting> Settings { set; get; }
        public DbSet<SocialApi> SocialApis { set; get; }
        public DbSet<SocialType> SocialTypes { set; get; }
        public DbSet<SystemExceptionLog> SystemExceptionLogs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<University> Universities { set; get; }
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

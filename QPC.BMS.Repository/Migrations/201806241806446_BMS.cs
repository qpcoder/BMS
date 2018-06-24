/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BMS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DisplayName = c.String(),
                        Permalink = c.String(),
                        Gender = c.Int(),
                        BirthDay = c.DateTime(nullable: false),
                        Address = c.String(),
                        DistrictID = c.Int(nullable: false),
                        AuthorPostID = c.Int(),
                        StudentID = c.Int(),
                        Email = c.String(),
                        Phone = c.String(),
                        StarLevel = c.Int(nullable: false),
                        TotalPoint = c.Int(nullable: false),
                        TotalVote = c.Int(nullable: false),
                        Website = c.String(),
                        FaceBook = c.String(),
                        Twitter = c.String(),
                        Zalo = c.String(),
                        Youtube = c.String(),
                        Evernote = c.String(),
                        GooglePlus = c.String(),
                        Linkedin = c.String(),
                        Instagram = c.String(),
                        Flickr = c.String(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        RoleID = c.Int(nullable: false),
                        TotalPost = c.Int(nullable: false),
                        TotalComment = c.Int(nullable: false),
                        LastLoginDate = c.DateTime(nullable: false),
                        AvatarPath = c.String(),
                        AccountParentID = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AuthorPosts", t => t.AuthorPostID)
                .ForeignKey("dbo.Districts", t => t.DistrictID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.DistrictID)
                .Index(t => t.AuthorPostID)
                .Index(t => t.StudentID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.AuthorPosts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        AllowTag = c.Boolean(),
                        AllowSeries = c.Boolean(),
                        DateCreate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        Description = c.String(),
                        ProvinceID = c.Int(nullable: false),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Provinces", t => t.ProvinceID, cascadeDelete: true)
                .Index(t => t.ProvinceID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CountryID = c.Int(nullable: false),
                        Code = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Lang = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TotalMember = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GraderID = c.Int(nullable: false),
                        MSSV = c.String(),
                        Specialized = c.String(),
                        GraduationYear = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Graders", t => t.GraderID, cascadeDelete: true)
                .Index(t => t.GraderID);
            
            CreateTable(
                "dbo.Graders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        FacultyID = c.Int(nullable: false),
                        Description = c.String(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Faculties", t => t.FacultyID, cascadeDelete: true)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        UniversityID = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Universities", t => t.UniversityID, cascadeDelete: true)
                .Index(t => t.UniversityID);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        DistrictID = c.Int(nullable: false),
                        Fax = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Districts", t => t.DistrictID, cascadeDelete: true)
                .Index(t => t.DistrictID);
            
            CreateTable(
                "dbo.ApiAuthorizes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        DateCreate = c.DateTime(),
                        IsActive = c.Boolean(),
                        Apikey = c.String(),
                        SecretKey = c.String(),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.AuditingLogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LoginName = c.String(),
                        ComputerName = c.String(),
                        ComputerIP = c.String(),
                        MiduleID = c.Int(nullable: false),
                        DateCreate = c.DateTime(),
                        ActionName = c.Int(nullable: false),
                        Description = c.String(),
                        ActionURL = c.String(),
                        Module_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Modules", t => t.Module_ID)
                .Index(t => t.Module_ID);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ModuleURL = c.String(),
                        Description = c.String(),
                        DateCreate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        ModuleID = c.Int(nullable: false),
                        AuView = c.Boolean(),
                        AuInsert = c.Boolean(),
                        AuUpdate = c.Boolean(),
                        AuDelete = c.Boolean(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Modules", t => t.ModuleID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.ModuleID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                        Content = c.String(),
                        UpVote = c.Int(nullable: false),
                        DownVote = c.Int(nullable: false),
                        IPAddress = c.String(),
                        CommentParentID = c.Int(nullable: false),
                        DateCreate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        PostTypeID = c.Int(nullable: false),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Title = c.String(),
                        Excerpt = c.String(),
                        Permalink = c.String(),
                        Content = c.String(),
                        FeaturedImageID = c.Int(nullable: false),
                        AllowComment = c.Boolean(),
                        CommentTotal = c.Int(nullable: false),
                        StarLevel = c.Int(nullable: false),
                        UpVote = c.Int(nullable: false),
                        DownVote = c.Int(nullable: false),
                        AuthorPostID = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Media_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AuthorPosts", t => t.AuthorPostID, cascadeDelete: true)
                .ForeignKey("dbo.Media", t => t.Media_ID)
                .ForeignKey("dbo.PostTypes", t => t.PostTypeID, cascadeDelete: true)
                .Index(t => t.PostTypeID)
                .Index(t => t.AuthorPostID)
                .Index(t => t.Media_ID);
            
            CreateTable(
                "dbo.Media",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MediaTypeID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        FileName = c.String(),
                        Alt = c.String(),
                        Permalink = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        FileSize = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.MediaTypes", t => t.MediaTypeID, cascadeDelete: true)
                .Index(t => t.MediaTypeID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.MediaTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        TypeExtention = c.String(),
                        DateCreate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PostTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Permalink = c.String(),
                        Excerpt = c.String(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        FeatureImageID = c.Int(nullable: false),
                        PostCount = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Media_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Media", t => t.Media_ID)
                .Index(t => t.Media_ID);
            
            CreateTable(
                "dbo.Downloads",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                        FileSize = c.Single(nullable: false),
                        DateUpload = c.DateTime(),
                        AccountID = c.Int(nullable: false),
                        TotalClick = c.Int(nullable: false),
                        LinkDownload = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.DownloadTrackings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DownloadID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        IPAddress = c.String(),
                        WebBrower = c.String(),
                        DateTracking = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Downloads", t => t.DownloadID, cascadeDelete: true)
                .Index(t => t.DownloadID);
            
            CreateTable(
                "dbo.NavigationMenus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DisplayName = c.String(),
                        MenuParentID = c.String(),
                        URL = c.String(),
                        DateCreate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RefPostWithTags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TagID = c.Int(nullable: false),
                        PostID = c.Int(nullable: false),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Satus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.TagID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        Name = c.String(),
                        Permalink = c.String(),
                        Excerpt = c.String(),
                        Description = c.String(),
                        DateCreate = c.String(),
                        DateUpdate = c.String(),
                        PostCount = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        Name = c.String(),
                        Permalink = c.String(),
                        Excerpt = c.String(),
                        Description = c.String(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        PostCount = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        Value = c.String(),
                        IsAutoLoad = c.Boolean(),
                        DateCreate = c.DateTime(),
                        DateUpdate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SocialApis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SocialTypeID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        ApiKey = c.String(),
                        ApiValue = c.String(),
                        DateCreate = c.DateTime(),
                        Status = c.String(),
                        SocialType_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.SocialTypes", t => t.SocialType_ID)
                .Index(t => t.AccountID)
                .Index(t => t.SocialType_ID);
            
            CreateTable(
                "dbo.SocialTypes",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        DateCreate = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SystemExceptionLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        DateCreated = c.DateTime(),
                        Message = c.String(),
                        StackTrace = c.String(),
                        Source = c.String(),
                        Url = c.String(),
                        TargetSite = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SocialApis", "SocialType_ID", "dbo.SocialTypes");
            DropForeignKey("dbo.SocialApis", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Series", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.RefPostWithTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.Tags", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.RefPostWithTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.DownloadTrackings", "DownloadID", "dbo.Downloads");
            DropForeignKey("dbo.Downloads", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PostTypeID", "dbo.PostTypes");
            DropForeignKey("dbo.PostTypes", "Media_ID", "dbo.Media");
            DropForeignKey("dbo.Posts", "Media_ID", "dbo.Media");
            DropForeignKey("dbo.Media", "MediaTypeID", "dbo.MediaTypes");
            DropForeignKey("dbo.Media", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Posts", "AuthorPostID", "dbo.AuthorPosts");
            DropForeignKey("dbo.Authorizations", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Authorizations", "ModuleID", "dbo.Modules");
            DropForeignKey("dbo.AuditingLogs", "Module_ID", "dbo.Modules");
            DropForeignKey("dbo.ApiAuthorizes", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "GraderID", "dbo.Graders");
            DropForeignKey("dbo.Graders", "FacultyID", "dbo.Faculties");
            DropForeignKey("dbo.Faculties", "UniversityID", "dbo.Universities");
            DropForeignKey("dbo.Universities", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Accounts", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Accounts", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Districts", "ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Provinces", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Accounts", "AuthorPostID", "dbo.AuthorPosts");
            DropIndex("dbo.SocialApis", new[] { "SocialType_ID" });
            DropIndex("dbo.SocialApis", new[] { "AccountID" });
            DropIndex("dbo.Series", new[] { "AccountID" });
            DropIndex("dbo.Tags", new[] { "AccountID" });
            DropIndex("dbo.RefPostWithTags", new[] { "PostID" });
            DropIndex("dbo.RefPostWithTags", new[] { "TagID" });
            DropIndex("dbo.DownloadTrackings", new[] { "DownloadID" });
            DropIndex("dbo.Downloads", new[] { "AccountID" });
            DropIndex("dbo.PostTypes", new[] { "Media_ID" });
            DropIndex("dbo.Media", new[] { "AccountID" });
            DropIndex("dbo.Media", new[] { "MediaTypeID" });
            DropIndex("dbo.Posts", new[] { "Media_ID" });
            DropIndex("dbo.Posts", new[] { "AuthorPostID" });
            DropIndex("dbo.Posts", new[] { "PostTypeID" });
            DropIndex("dbo.Comments", new[] { "PostID" });
            DropIndex("dbo.Authorizations", new[] { "ModuleID" });
            DropIndex("dbo.Authorizations", new[] { "RoleID" });
            DropIndex("dbo.AuditingLogs", new[] { "Module_ID" });
            DropIndex("dbo.ApiAuthorizes", new[] { "AccountID" });
            DropIndex("dbo.Universities", new[] { "DistrictID" });
            DropIndex("dbo.Faculties", new[] { "UniversityID" });
            DropIndex("dbo.Graders", new[] { "FacultyID" });
            DropIndex("dbo.Students", new[] { "GraderID" });
            DropIndex("dbo.Provinces", new[] { "CountryID" });
            DropIndex("dbo.Districts", new[] { "ProvinceID" });
            DropIndex("dbo.Accounts", new[] { "RoleID" });
            DropIndex("dbo.Accounts", new[] { "StudentID" });
            DropIndex("dbo.Accounts", new[] { "AuthorPostID" });
            DropIndex("dbo.Accounts", new[] { "DistrictID" });
            DropTable("dbo.SystemExceptionLogs");
            DropTable("dbo.SocialTypes");
            DropTable("dbo.SocialApis");
            DropTable("dbo.Settings");
            DropTable("dbo.Series");
            DropTable("dbo.Tags");
            DropTable("dbo.RefPostWithTags");
            DropTable("dbo.NavigationMenus");
            DropTable("dbo.DownloadTrackings");
            DropTable("dbo.Downloads");
            DropTable("dbo.PostTypes");
            DropTable("dbo.MediaTypes");
            DropTable("dbo.Media");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Authorizations");
            DropTable("dbo.Modules");
            DropTable("dbo.AuditingLogs");
            DropTable("dbo.ApiAuthorizes");
            DropTable("dbo.Universities");
            DropTable("dbo.Faculties");
            DropTable("dbo.Graders");
            DropTable("dbo.Students");
            DropTable("dbo.Roles");
            DropTable("dbo.Countries");
            DropTable("dbo.Provinces");
            DropTable("dbo.Districts");
            DropTable("dbo.AuthorPosts");
            DropTable("dbo.Accounts");
        }
    }
}

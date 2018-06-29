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
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                    })
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
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
                    })
                .PrimaryKey(t => t.ID);
            
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
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GraderID = c.Int(nullable: false),
                        MSSV = c.String(),
                        Specialized = c.String(),
                        GraduationYear = c.String(),
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
                .PrimaryKey(t => t.ID);
            
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
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "RoleID", "dbo.Roles");
            DropIndex("dbo.Accounts", new[] { "RoleID" });
            DropTable("dbo.Universities");
            DropTable("dbo.Tags");
            DropTable("dbo.SystemExceptionLogs");
            DropTable("dbo.Students");
            DropTable("dbo.SocialTypes");
            DropTable("dbo.SocialApis");
            DropTable("dbo.Settings");
            DropTable("dbo.Series");
            DropTable("dbo.RefPostWithTags");
            DropTable("dbo.Provinces");
            DropTable("dbo.PostTypes");
            DropTable("dbo.Posts");
            DropTable("dbo.NavigationMenus");
            DropTable("dbo.Modules");
            DropTable("dbo.MediaTypes");
            DropTable("dbo.Media");
            DropTable("dbo.Graders");
            DropTable("dbo.Faculties");
            DropTable("dbo.DownloadTrackings");
            DropTable("dbo.Downloads");
            DropTable("dbo.Districts");
            DropTable("dbo.Countries");
            DropTable("dbo.Comments");
            DropTable("dbo.AuthorPosts");
            DropTable("dbo.Authorizations");
            DropTable("dbo.AuditingLogs");
            DropTable("dbo.ApiAuthorizes");
            DropTable("dbo.Roles");
            DropTable("dbo.Accounts");
        }
    }
}

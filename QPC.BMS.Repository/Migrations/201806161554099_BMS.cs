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
                        ID = c.Guid(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        NickName = c.String(),
                        DisplayNamePublic = c.String(),
                        Gender = c.String(),
                        GraderID = c.Int(),
                        MSSV = c.String(),
                        Specialized = c.String(),
                        GraduationYear = c.DateTime(),
                        BirthDay = c.DateTime(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
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
                        Permalink = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        IsStudent = c.Boolean(),
                        RoleID = c.Int(),
                        IsActivitied = c.Boolean(),
                        PostCount = c.Int(),
                        CommentCount = c.Int(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Graders", t => t.GraderID)
                .ForeignKey("dbo.Roles", t => t.RoleID)
                .Index(t => t.GraderID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Graders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        FacultyID = c.Int(),
                        Description = c.String(),
                        DateCreared = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Faculties", t => t.FacultyID)
                .Index(t => t.FacultyID);
            
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        UniversityID = c.Int(),
                        Name = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Universities", t => t.UniversityID)
                .Index(t => t.UniversityID);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        DistrictID = c.Int(),
                        Fax = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Districts", t => t.DistrictID)
                .Index(t => t.DistrictID);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        ProvinceID = c.Int(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Provinces", t => t.ProvinceID)
                .Index(t => t.ProvinceID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CountryID = c.Int(),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.CountryID)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        Status = c.Boolean(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Authorizations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(),
                        ModuleID = c.Int(),
                        AuView = c.Boolean(),
                        AuInsert = c.Boolean(),
                        AuUpdate = c.Boolean(),
                        AuDelete = c.Boolean(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Modules", t => t.ModuleID)
                .ForeignKey("dbo.Roles", t => t.RoleID)
                .Index(t => t.RoleID)
                .Index(t => t.ModuleID);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Title = c.String(),
                        Code = c.String(),
                        Excerpt = c.String(),
                        Permalink = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AccountID = c.Guid(),
                        PostID = c.Guid(),
                        Content = c.String(),
                        Approved = c.String(),
                        IPAddress = c.String(),
                        Agent = c.String(),
                        CommentParentID = c.Guid(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .ForeignKey("dbo.Posts", t => t.PostID)
                .Index(t => t.AccountID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AccountID = c.Guid(),
                        PostTypeID = c.Guid(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Title = c.String(),
                        Excerpt = c.String(),
                        Permalink = c.String(),
                        Content = c.String(),
                        ImageID = c.Guid(),
                        Status = c.Boolean(),
                        AllowComments = c.Boolean(),
                        CommentCount = c.Int(nullable: false),
                        MetaTitle = c.String(),
                        MetaKeywords = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .ForeignKey("dbo.Images", t => t.ImageID)
                .ForeignKey("dbo.PostTypes", t => t.PostTypeID)
                .Index(t => t.AccountID)
                .Index(t => t.PostTypeID)
                .Index(t => t.ImageID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AccountID = c.Guid(),
                        Code = c.String(),
                        Name = c.String(),
                        Alt = c.String(),
                        Permalink = c.String(),
                        DateCreated = c.DateTime(),
                        ImageSize = c.Int(nullable: false),
                        IsAvatar = c.Boolean(),
                        IsBackground = c.Boolean(),
                        IsFeaturedPost = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.PostTypes",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        Permalink = c.String(),
                        Excerpt = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        ImageID = c.Guid(),
                        PostCount = c.Int(nullable: false),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Images", t => t.ImageID)
                .Index(t => t.ImageID);
            
            CreateTable(
                "dbo.Downloads",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FileName = c.String(),
                        FileSize = c.Int(nullable: false),
                        DateUpload = c.DateTime(),
                        AccountID = c.Guid(),
                        DownlaodCount = c.Int(nullable: false),
                        LinkDownload = c.String(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Date = c.DateTime(),
                        Thread = c.String(),
                        Level = c.String(),
                        Logger = c.String(),
                        Message = c.String(),
                        Exceptions = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RefPostWithTags",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        TagID = c.Guid(),
                        PostID = c.Guid(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Satus = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Posts", t => t.PostID)
                .ForeignKey("dbo.Tags", t => t.TagID)
                .Index(t => t.TagID)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AccountID = c.Guid(),
                        Name = c.String(),
                        Permalink = c.String(),
                        Excerpt = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        PostCount = c.Int(nullable: false),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        AccountID = c.Guid(),
                        Name = c.String(),
                        Code = c.String(),
                        Permalink = c.String(),
                        Excerpt = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        PostCount = c.Int(nullable: false),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Value = c.String(),
                        AutoLoad = c.Boolean(),
                        DateCreated = c.DateTime(),
                        DateUpdated = c.DateTime(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Series", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.RefPostWithTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.Tags", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.RefPostWithTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Downloads", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Comments", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PostTypeID", "dbo.PostTypes");
            DropForeignKey("dbo.PostTypes", "ImageID", "dbo.Images");
            DropForeignKey("dbo.Posts", "ImageID", "dbo.Images");
            DropForeignKey("dbo.Images", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Posts", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Comments", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Authorizations", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Authorizations", "ModuleID", "dbo.Modules");
            DropForeignKey("dbo.Accounts", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Accounts", "GraderID", "dbo.Graders");
            DropForeignKey("dbo.Graders", "FacultyID", "dbo.Faculties");
            DropForeignKey("dbo.Faculties", "UniversityID", "dbo.Universities");
            DropForeignKey("dbo.Universities", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Districts", "ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Provinces", "CountryID", "dbo.Countries");
            DropIndex("dbo.Series", new[] { "AccountID" });
            DropIndex("dbo.Tags", new[] { "AccountID" });
            DropIndex("dbo.RefPostWithTags", new[] { "PostID" });
            DropIndex("dbo.RefPostWithTags", new[] { "TagID" });
            DropIndex("dbo.Downloads", new[] { "AccountID" });
            DropIndex("dbo.PostTypes", new[] { "ImageID" });
            DropIndex("dbo.Images", new[] { "AccountID" });
            DropIndex("dbo.Posts", new[] { "ImageID" });
            DropIndex("dbo.Posts", new[] { "PostTypeID" });
            DropIndex("dbo.Posts", new[] { "AccountID" });
            DropIndex("dbo.Comments", new[] { "PostID" });
            DropIndex("dbo.Comments", new[] { "AccountID" });
            DropIndex("dbo.Authorizations", new[] { "ModuleID" });
            DropIndex("dbo.Authorizations", new[] { "RoleID" });
            DropIndex("dbo.Provinces", new[] { "CountryID" });
            DropIndex("dbo.Districts", new[] { "ProvinceID" });
            DropIndex("dbo.Universities", new[] { "DistrictID" });
            DropIndex("dbo.Faculties", new[] { "UniversityID" });
            DropIndex("dbo.Graders", new[] { "FacultyID" });
            DropIndex("dbo.Accounts", new[] { "RoleID" });
            DropIndex("dbo.Accounts", new[] { "GraderID" });
            DropTable("dbo.Settings");
            DropTable("dbo.Series");
            DropTable("dbo.Tags");
            DropTable("dbo.RefPostWithTags");
            DropTable("dbo.Logs");
            DropTable("dbo.Downloads");
            DropTable("dbo.PostTypes");
            DropTable("dbo.Images");
            DropTable("dbo.Posts");
            DropTable("dbo.Comments");
            DropTable("dbo.Modules");
            DropTable("dbo.Authorizations");
            DropTable("dbo.Roles");
            DropTable("dbo.Countries");
            DropTable("dbo.Provinces");
            DropTable("dbo.Districts");
            DropTable("dbo.Universities");
            DropTable("dbo.Faculties");
            DropTable("dbo.Graders");
            DropTable("dbo.Accounts");
        }
    }
}

namespace DemoAppWithRepositoryAutofac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addition : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        CountryId = c.Guid(nullable: false),
                        CountryName = c.String(nullable: false, maxLength: 50),
                        CountryCode = c.String(maxLength: 5),
                        CountryPhoneCode = c.String(maxLength: 7),
                        Status = c.String(nullable: false, maxLength: 10),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Guid(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.State",
                c => new
                    {
                        StateId = c.Guid(nullable: false),
                        CountryId = c.Guid(nullable: false),
                        StateName = c.String(nullable: false, maxLength: 50),
                        StateCode = c.String(maxLength: 5),
                        Status = c.String(nullable: false, maxLength: 10),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Guid(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        CityId = c.Guid(nullable: false),
                        StateId = c.Guid(nullable: false),
                        CityName = c.String(nullable: false, maxLength: 50),
                        CityCode = c.String(maxLength: 5),
                        CityPhoneCode = c.String(maxLength: 7),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.State", t => t.StateId, cascadeDelete: true)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        usertype = c.String(nullable: false, maxLength: 10),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        Salutation = c.String(maxLength: 10),
                        FirstName = c.String(maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Sex = c.String(maxLength: 6),
                        SocialSecurityNnumber = c.String(maxLength: 100),
                        BloodGroupId = c.Guid(),
                        AddressLine1 = c.String(maxLength: 150),
                        AddressLine2 = c.String(maxLength: 150),
                        CityId = c.Guid(),
                        EmailId = c.String(maxLength: 50),
                        MobileNumber = c.String(maxLength: 15),
                        HomePhoneNumber = c.String(maxLength: 15),
                        WorkPhoneNumber1 = c.String(maxLength: 15),
                        WorkPhoneNumber2 = c.String(maxLength: 15),
                        Status = c.String(nullable: false, maxLength: 10),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.Guid(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.City", t => t.CityId)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.State", "CountryId", "dbo.Country");
            DropForeignKey("dbo.Users", "CityId", "dbo.City");
            DropForeignKey("dbo.City", "StateId", "dbo.State");
            DropIndex("dbo.Users", new[] { "CityId" });
            DropIndex("dbo.City", new[] { "StateId" });
            DropIndex("dbo.State", new[] { "CountryId" });
            DropTable("dbo.Users");
            DropTable("dbo.City");
            DropTable("dbo.State");
            DropTable("dbo.Country");
        }
    }
}

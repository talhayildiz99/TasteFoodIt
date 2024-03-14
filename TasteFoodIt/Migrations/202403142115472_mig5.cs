namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mails",
                c => new
                    {
                        MailId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MailId);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        ResturantName = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaId = c.Int(nullable: false, identity: true),
                        PlatformName = c.String(),
                        IconUrl = c.String(),
                        RedirectUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SocialMediaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Sliders");
            DropTable("dbo.Mails");
        }
    }
}

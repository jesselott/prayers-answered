namespace PrayersAnswered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePrayerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UpVote = c.Int(nullable: false),
                        Content = c.String(),
                        Commentor_Id = c.String(maxLength: 128),
                        Prayer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Commentor_Id)
                .ForeignKey("dbo.Prayers", t => t.Prayer_Id)
                .Index(t => t.Commentor_Id)
                .Index(t => t.Prayer_Id);
            
            CreateTable(
                "dbo.Prayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        IsAnswered = c.Boolean(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        PrayingForYou = c.Int(nullable: false),
                        Poster_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Poster_Id)
                .Index(t => t.Poster_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Prayer_Id", "dbo.Prayers");
            DropForeignKey("dbo.Comments", "Commentor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Prayers", new[] { "Poster_Id" });
            DropIndex("dbo.Comments", new[] { "Prayer_Id" });
            DropIndex("dbo.Comments", new[] { "Commentor_Id" });
            DropTable("dbo.Prayers");
            DropTable("dbo.Comments");
        }
    }
}

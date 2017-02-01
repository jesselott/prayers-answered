namespace PrayersAnswered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForDomain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Commentor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Comments", new[] { "Commentor_Id" });
            DropIndex("dbo.Prayers", new[] { "Poster_Id" });
            AlterColumn("dbo.Comments", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Commentor_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Prayers", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Prayers", "Content", c => c.String(nullable: false));
            AlterColumn("dbo.Prayers", "Poster_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Comments", "Commentor_Id");
            CreateIndex("dbo.Prayers", "Poster_Id");
            AddForeignKey("dbo.Comments", "Commentor_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Commentor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Prayers", new[] { "Poster_Id" });
            DropIndex("dbo.Comments", new[] { "Commentor_Id" });
            AlterColumn("dbo.Prayers", "Poster_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Prayers", "Content", c => c.String());
            AlterColumn("dbo.Prayers", "Title", c => c.String());
            AlterColumn("dbo.Comments", "Commentor_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Comments", "Content", c => c.String());
            CreateIndex("dbo.Prayers", "Poster_Id");
            CreateIndex("dbo.Comments", "Commentor_Id");
            AddForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Comments", "Commentor_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

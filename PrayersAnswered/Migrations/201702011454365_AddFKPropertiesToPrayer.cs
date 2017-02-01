namespace PrayersAnswered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKPropertiesToPrayer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Prayers", new[] { "Poster_Id" });
            AddColumn("dbo.Prayers", "ArtistId", c => c.String(nullable: false));
            AlterColumn("dbo.Prayers", "Poster_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Prayers", "Poster_Id");
            AddForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Prayers", new[] { "Poster_Id" });
            AlterColumn("dbo.Prayers", "Poster_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Prayers", "ArtistId");
            CreateIndex("dbo.Prayers", "Poster_Id");
            AddForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}

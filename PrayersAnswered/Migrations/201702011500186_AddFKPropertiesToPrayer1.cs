namespace PrayersAnswered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFKPropertiesToPrayer1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Prayers", new[] { "Poster_Id" });
            RenameColumn(table: "dbo.Prayers", name: "Poster_Id", newName: "PosterId");
            AlterColumn("dbo.Prayers", "PosterId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Prayers", "PosterId");
            AddForeignKey("dbo.Prayers", "PosterId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Prayers", "ArtistId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Prayers", "ArtistId", c => c.String(nullable: false));
            DropForeignKey("dbo.Prayers", "PosterId", "dbo.AspNetUsers");
            DropIndex("dbo.Prayers", new[] { "PosterId" });
            AlterColumn("dbo.Prayers", "PosterId", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.Prayers", name: "PosterId", newName: "Poster_Id");
            CreateIndex("dbo.Prayers", "Poster_Id");
            AddForeignKey("dbo.Prayers", "Poster_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

namespace PrayersAnswered.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationalChangeComment : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Comments", new[] { "Prayer_Id" });
            CreateIndex("dbo.Comments", "prayer_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Comments", new[] { "prayer_Id" });
            CreateIndex("dbo.Comments", "Prayer_Id");
        }
    }
}

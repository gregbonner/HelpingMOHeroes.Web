namespace HelpingMOHeroes.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LocationFK : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Event", "LocationId");
            AddForeignKey("dbo.Event", "LocationId", "dbo.Location", "LocationId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Event", "LocationId", "dbo.Location");
            DropIndex("dbo.Event", new[] { "LocationId" });
        }
    }
}

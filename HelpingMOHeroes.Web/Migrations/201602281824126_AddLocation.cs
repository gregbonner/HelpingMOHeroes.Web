namespace HelpingMOHeroes.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        LocationName = c.String(),
                        Address = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZIP = c.String(),
                        AddDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
            AddColumn("dbo.Event", "LocationId", c => c.Int(nullable: false));
            DropColumn("dbo.Event", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Event", "Location", c => c.String());
            DropColumn("dbo.Event", "LocationId");
            DropTable("dbo.Location");
        }
    }
}

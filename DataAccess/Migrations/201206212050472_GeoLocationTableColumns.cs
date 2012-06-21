namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Spatial;
    
    public partial class GeoLocationTableColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "GeoLoc", c => c.Geography());
            AddColumn("dbo.Customer", "Longitude", c => c.Single(nullable: false));
            AddColumn("dbo.Customer", "Latitude", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Latitude");
            DropColumn("dbo.Customer", "Longitude");
            DropColumn("dbo.Customer", "GeoLoc");
        }
    }
}

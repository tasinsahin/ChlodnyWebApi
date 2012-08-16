namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.Spatial;
    
    public partial class GeoLocationToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "GeoLoc", c => c.Geography());
            AddColumn("dbo.Employee", "Longitude", c => c.Single());
            AddColumn("dbo.Employee", "Latitude", c => c.Single());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Latitude");
            DropColumn("dbo.Employee", "Longitude");
            DropColumn("dbo.Employee", "GeoLoc");
        }
    }
}

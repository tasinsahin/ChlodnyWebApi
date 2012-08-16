namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedLatLongToAllowNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Longitude", c => c.Single());
            AlterColumn("dbo.Customer", "Latitude", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Latitude", c => c.Single(nullable: false));
            AlterColumn("dbo.Customer", "Longitude", c => c.Single(nullable: false));
        }
    }
}

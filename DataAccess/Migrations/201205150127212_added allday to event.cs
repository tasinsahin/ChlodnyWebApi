namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class addedalldaytoevent : DbMigration
    {
        public override void Up()
        {
            AddColumn("Events", "AllDay", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Events", "AllDay");
        }
    }
}

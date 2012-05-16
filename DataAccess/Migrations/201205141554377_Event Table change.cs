namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class EventTablechange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Events", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("Events", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Events", "EndDate", c => c.DateTime());
            AlterColumn("Events", "StartDate", c => c.DateTime());
        }
    }
}

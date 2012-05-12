namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddEventTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventDescription = c.String(maxLength: 250),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropTable("Events");
        }
    }
}

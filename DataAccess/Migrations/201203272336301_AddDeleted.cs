namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("Customer", "Deleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Customer", "Deleted");
        }
    }
}

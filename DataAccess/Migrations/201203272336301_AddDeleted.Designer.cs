// <auto-generated />
namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class AddDeleted : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201203272336301_AddDeleted"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}

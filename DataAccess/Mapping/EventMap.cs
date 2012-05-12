namespace DataAccess.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    using DataAccess.Entities;

    public class EventMap : EntityTypeConfiguration<Event>
    {
         public EventMap()
         {
             // Properties
            this.Property(t => t.EventDescription).HasMaxLength(250);
         }
    }
}
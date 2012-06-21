namespace DataAccess.MappingChinook
{
    using System.Data.Entity.ModelConfiguration;

    using DomainClasses.EntitiesChinook;

    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Properties
            this.Property(t => t.EventDescription).HasMaxLength(250);
        }
    }
}
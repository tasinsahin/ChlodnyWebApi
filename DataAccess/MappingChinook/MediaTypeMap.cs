namespace DataAccess.MappingChinook
{
    using System.Data.Entity.ModelConfiguration;

    using DomainClasses.EntitiesChinook;

    public class MediaTypeMap : EntityTypeConfiguration<MediaType>
    {
        public MediaTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.MediaTypeId);

            // Properties
            this.Property(t => t.Name).HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("MediaType");
            this.Property(t => t.MediaTypeId).HasColumnName("MediaTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
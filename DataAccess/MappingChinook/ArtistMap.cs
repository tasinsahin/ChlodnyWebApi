namespace DataAccess.MappingChinook
{
    using System.Data.Entity.ModelConfiguration;

    using DomainClasses.EntitiesChinook;

    public class ArtistMap : EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            // Primary Key
            this.HasKey(t => t.ArtistId);

            // Properties
            this.Property(t => t.Name).HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("Artist");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
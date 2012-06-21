namespace DataAccess.MappingChinook
{
    using System.Data.Entity.ModelConfiguration;

    using DomainClasses.EntitiesChinook;

    public class AlbumMap : EntityTypeConfiguration<Album>
    {
        public AlbumMap()
        {
            // Primary Key
            this.HasKey(t => t.AlbumId);

            // Properties
            this.Property(t => t.Title).IsRequired().HasMaxLength(160);

            // Table & Column Mappings
            this.ToTable("Album");
            this.Property(t => t.AlbumId).HasColumnName("AlbumId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.ArtistId).HasColumnName("ArtistId");
        }
    }
}
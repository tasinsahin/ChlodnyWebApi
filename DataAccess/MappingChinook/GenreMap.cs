namespace DataAccess.MappingChinook
{
    using System.Data.Entity.ModelConfiguration;

    using DomainClasses.EntitiesChinook;

    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            // Primary Key
            this.HasKey(t => t.GenreId);

            // Properties
            this.Property(t => t.Name).HasMaxLength(120);

            // Table & Column Mappings
            this.ToTable("Genre");
            this.Property(t => t.GenreId).HasColumnName("GenreId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
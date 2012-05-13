namespace DataAccess
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using DataAccess.Entities;
    using DataAccess.Mapping;

    public class ChinookContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceLine> InvoiceLines { get; set; }

        public DbSet<MediaType> MediaTypes { get; set; }

        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new AlbumMap());
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new InvoiceLineMap());
            modelBuilder.Configurations.Add(new MediaTypeMap());
            modelBuilder.Configurations.Add(new PlaylistMap());
            modelBuilder.Configurations.Add(new PlaylistTrackMap());
            modelBuilder.Configurations.Add(new TrackMap());
            modelBuilder.Configurations.Add(new EventMap());
        }
    }
}
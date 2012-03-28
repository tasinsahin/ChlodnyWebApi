namespace DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "Album",
            //    c => new
            //        {
            //            AlbumId = c.Int(nullable: false, identity: true),
            //            Title = c.String(nullable: false, maxLength: 160),
            //            ArtistId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.AlbumId);
            
            //CreateTable(
            //    "Artist",
            //    c => new
            //        {
            //            ArtistId = c.Int(nullable: false, identity: true),
            //            Name = c.String(maxLength: 120),
            //        })
            //    .PrimaryKey(t => t.ArtistId);
            
            //CreateTable(
            //    "Customer",
            //    c => new
            //        {
            //            CustomerId = c.Int(nullable: false, identity: true),
            //            FirstName = c.String(nullable: false, maxLength: 40),
            //            LastName = c.String(nullable: false, maxLength: 20),
            //            Company = c.String(maxLength: 80),
            //            Address = c.String(maxLength: 70),
            //            City = c.String(maxLength: 40),
            //            State = c.String(maxLength: 40),
            //            Country = c.String(maxLength: 40),
            //            PostalCode = c.String(maxLength: 10),
            //            Phone = c.String(maxLength: 24),
            //            Fax = c.String(maxLength: 24),
            //            Email = c.String(nullable: false, maxLength: 60),
            //            SupportRepId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.CustomerId);
            
            //CreateTable(
            //    "Employee",
            //    c => new
            //        {
            //            EmployeeId = c.Int(nullable: false, identity: true),
            //            LastName = c.String(nullable: false, maxLength: 20),
            //            FirstName = c.String(nullable: false, maxLength: 20),
            //            Title = c.String(maxLength: 30),
            //            ReportsTo = c.Int(),
            //            BirthDate = c.DateTime(),
            //            HireDate = c.DateTime(),
            //            Address = c.String(maxLength: 70),
            //            City = c.String(maxLength: 40),
            //            State = c.String(maxLength: 40),
            //            Country = c.String(maxLength: 40),
            //            PostalCode = c.String(maxLength: 10),
            //            Phone = c.String(maxLength: 24),
            //            Fax = c.String(maxLength: 24),
            //            Email = c.String(maxLength: 60),
            //        })
            //    .PrimaryKey(t => t.EmployeeId);
            
            //CreateTable(
            //    "Genre",
            //    c => new
            //        {
            //            GenreId = c.Int(nullable: false, identity: true),
            //            Name = c.String(maxLength: 120),
            //        })
            //    .PrimaryKey(t => t.GenreId);
            
            //CreateTable(
            //    "Invoice",
            //    c => new
            //        {
            //            InvoiceId = c.Int(nullable: false, identity: true),
            //            CustomerId = c.Int(nullable: false),
            //            InvoiceDate = c.DateTime(nullable: false),
            //            BillingAddress = c.String(maxLength: 70),
            //            BillingCity = c.String(maxLength: 40),
            //            BillingState = c.String(maxLength: 40),
            //            BillingCountry = c.String(maxLength: 40),
            //            BillingPostalCode = c.String(maxLength: 10),
            //            Total = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.InvoiceId);
            
            //CreateTable(
            //    "InvoiceLine",
            //    c => new
            //        {
            //            InvoiceLineId = c.Int(nullable: false, identity: true),
            //            InvoiceId = c.Int(nullable: false),
            //            TrackId = c.Int(nullable: false),
            //            UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Quantity = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.InvoiceLineId);
            
            //CreateTable(
            //    "MediaType",
            //    c => new
            //        {
            //            MediaTypeId = c.Int(nullable: false, identity: true),
            //            Name = c.String(maxLength: 120),
            //        })
            //    .PrimaryKey(t => t.MediaTypeId);
            
            //CreateTable(
            //    "Playlist",
            //    c => new
            //        {
            //            PlaylistId = c.Int(nullable: false, identity: true),
            //            Name = c.String(maxLength: 120),
            //        })
            //    .PrimaryKey(t => t.PlaylistId);
            
            //CreateTable(
            //    "PlaylistTrack",
            //    c => new
            //        {
            //            PlaylistId = c.Int(nullable: false),
            //            TrackId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.PlaylistId, t.TrackId });
            
            //CreateTable(
            //    "Track",
            //    c => new
            //        {
            //            TrackId = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 200),
            //            AlbumId = c.Int(),
            //            MediaTypeId = c.Int(nullable: false),
            //            GenreId = c.Int(),
            //            Composer = c.String(maxLength: 220),
            //            Milliseconds = c.Int(nullable: false),
            //            Bytes = c.Int(),
            //            UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.TrackId);
            
        }
        
        public override void Down()
        {
            //DropTable("Track");
            //DropTable("PlaylistTrack");
            //DropTable("Playlist");
            //DropTable("MediaType");
            //DropTable("InvoiceLine");
            //DropTable("Invoice");
            //DropTable("Genre");
            //DropTable("Employee");
            //DropTable("Customer");
            //DropTable("Artist");
            //DropTable("Album");
        }
    }
}

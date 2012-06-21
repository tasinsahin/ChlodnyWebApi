namespace DomainClasses.EntitiesChinook
{
    using System.Data.Spatial;

    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public bool Deleted { get; set; }

        public int? SupportRepId { get; set; }

        public DbGeography GeoLoc { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }
    }
}
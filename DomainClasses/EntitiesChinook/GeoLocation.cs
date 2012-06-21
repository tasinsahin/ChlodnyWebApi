namespace DomainClasses.EntitiesChinook
{
    using System.Data.Spatial;

    public class GeoLocation
    {
        public int GeoLocationId { get; set; }

        public DbGeography GeoLoc { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }

        public int PersonId { get; set; }
    }
}

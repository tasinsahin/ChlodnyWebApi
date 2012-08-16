namespace BingServices.BingMaps
{
    using System.Configuration;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    using BingServices.GeocodeService;

    public class GeoLocation
    {
        public Location GeocodeAddress(string address)
        {
            address = "Av. Brigadeiro Faria Lima, 2170 São José dos Campos SP 12227-000";
            var bingMapApiKey = ConfigurationManager.AppSettings["BingMapCredentials"];
            if (!string.IsNullOrEmpty(bingMapApiKey))
            {
                var geocodeRequest = new GeocodeRequest
                    { Credentials = new Credentials { ApplicationId = bingMapApiKey }, Query = address };

                // Set the options to only return high confidence results 
                //var filters = new ConfidenceFilter[1];
                //filters[0] = new ConfidenceFilter { MinimumConfidence = Confidence.High };
                //var geocodeOptions = new GeocodeOptions { Filters = filters };
                //geocodeRequest.Options = geocodeOptions;

                // Make the geocode request
                var binding = new BasicHttpBinding();
                var endpointAddress =
                    new EndpointAddress(
                        "http://dev.virtualearth.net/webservices/v1/geocodeservice/GeocodeService.svc?wsdl");

                //var geocodeService = new GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
                var geocodeService = new GeocodeServiceClient(binding, endpointAddress);
                var geocodeResponse = geocodeService.Geocode(geocodeRequest);

                if (geocodeResponse.Results.Length > 0)
                {
                    if (geocodeResponse.Results[0].Locations.Length > 0)
                    {
                        return geocodeResponse.Results[0].Locations[0];
                    }
                }
            }
            return null;
        }

        public string GeocodeReverseLookup(string latLong)
        {
            var bingMapApiKey = ConfigurationManager.AppSettings["BingMapCredentials"];
            var point = new Location();
            var latLongValue = latLong.Split(',');
            point.Latitude = double.Parse(latLongValue[0].Trim());
            point.Longitude = double.Parse(latLongValue[1].Trim());

            var reverseGeocodeRequest = new ReverseGeocodeRequest
                {
                    Credentials = new Credentials { ApplicationId = bingMapApiKey },
                    Location = point
                };

            var geocodeService = new GeocodeServiceClient();
            var geocodeResponse = geocodeService.ReverseGeocode(reverseGeocodeRequest);

            if(geocodeResponse.Results.Length > 0)
            {
                    return geocodeResponse.Results[0].DisplayName;
            }

            return null;
        }

        // internal string[] GLocation(string address)
        // {
        //    var bingMapApiKey = ConfigurationManager.AppSettings["BingMapCredentials"];
        //    var geocodeRequest = new GeocodeRequest { Credentials = new GeocodeService.Credentials { ApplicationId = bingMapApiKey }, Query = address };

             // Make the geocode request
        //    var geocodeService = new GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
        //    var geocodeResponse = geocodeService.Geocode(geocodeRequest);

            // string[] arr2 = { geocodeResponse.Results[0].Locations[0].Latitude.ToString(CultureInfo.InvariantCulture), geocodeResponse.Results[0].Locations[0].Longitude.ToString(CultureInfo.InvariantCulture) };
        //    return arr2;
        // }

        // internal string MapAddress(string address, int zoom, string mapStyle, int width, int height)
        // {
        //    Location latlong = this.GeocodeAddress(address);
        //    double latitude = latlong.Latitude;
        //    double longitude = latlong.Longitude;
        //    return this.GetMapUri(latitude, longitude, zoom, mapStyle, width, height);
        // }
    }
}
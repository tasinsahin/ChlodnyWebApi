namespace ChlodnyWebApi.BingMaps
{
    using System.Configuration;
    using System.Globalization;

   

    public class GeoLocation
    {
        //internal GeocodeService.Location GeocodeAddress(string address)
        //{
        //    var bingMapApiKey = ConfigurationManager.AppSettings["BingMapCredentials"];
        //    var geocodeRequest = new GeocodeRequest { Credentials = new GeocodeService.Credentials { ApplicationId = bingMapApiKey }, Query = address };

        //    // Set the credentials using a valid Bing Maps Key
        //    // Set the full address query

        //    // Set the options to only return high confidence results 
        //    var filters = new ConfidenceFilter[1];
        //    filters[0] = new ConfidenceFilter { MinimumConfidence = GeocodeService.Confidence.High };
        //    var geocodeOptions = new GeocodeOptions { Filters = filters };
        //    geocodeRequest.Options = geocodeOptions;

        //    // Make the geocode request
        //    var geocodeService = new GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
        //    GeocodeResponse geocodeResponse = geocodeService.Geocode(geocodeRequest);

        //    if (geocodeResponse.Results.Length > 0)
        //    {
        //        if (geocodeResponse.Results[0].Locations.Length > 0)
        //        {
        //            return geocodeResponse.Results[0].Locations[0];
        //        }
        //    }

        //    return null;
        //}

        //internal string[] GLocation(string address)
        //{
        //    var bingMapApiKey = ConfigurationManager.AppSettings["BingMapCredentials"];
        //    var geocodeRequest = new GeocodeRequest { Credentials = new GeocodeService.Credentials { ApplicationId = bingMapApiKey }, Query = address };

        //    // Make the geocode request
        //    var geocodeService = new GeocodeServiceClient("BasicHttpBinding_IGeocodeService");
        //    var geocodeResponse = geocodeService.Geocode(geocodeRequest);

        //    string[] arr2 = { geocodeResponse.Results[0].Locations[0].Latitude.ToString(CultureInfo.InvariantCulture), geocodeResponse.Results[0].Locations[0].Longitude.ToString(CultureInfo.InvariantCulture) };
        //    return arr2;
        //}

        //internal string MapAddress(string address, int zoom, string mapStyle, int width, int height)
        //{
        //    GeocodeService.Location latlong = this.GeocodeAddress(address);
        //    double latitude = latlong.Latitude;
        //    double longitude = latlong.Longitude;
        //    return this.GetMapUri(latitude, longitude, zoom, mapStyle, width, height);
        //}
    }
}
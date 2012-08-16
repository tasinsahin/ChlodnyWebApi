namespace BingServices.BingMaps
{
    using System;
    using System.Configuration;
    using System.Net.Http;
    using System.Threading.Tasks;

    //todo chadit play with this later
    public class BingMapsRest
    {
        public BingMapsRest()
        {
            this.BingMapsKey = ConfigurationManager.AppSettings["BingMapCredentials"];
        }

        public string BingMapsKey { get; set; }

        public async void GetLocationByAddress()
        {
            var client = new HttpClient();

            // Send a request asynchronously continue when complete
         //   HttpResponseMessage response = await client.GetAsync("http://api.worldbank.org/countries?format=json");

            // Read response asynchronously as JsonValue and write out top facts for each country
         //   JArray content = await response.Content.ReadAsAsync<JArray>();
         //   var test = content[1];

            // Send a request asynchronously continue when complete
            HttpResponseMessage response1 = await client.GetAsync("http://dev.virtualearth.net/REST/v1/Locations/US/WA/-/Ballard/-?o=json&inclnb=1&key=" + this.BingMapsKey);

            // Read response asynchronously as JsonValue and write out top facts for each country
           // var content1 = await response1.Content.ReadAsAsync<JObject>();
        //    var testbing = content1;
          


            client.GetAsync("http://dev.virtualearth.net/REST/v1/Locations/US/WA/-/Ballard/-?o=json&inclnb=1&key=" + this.BingMapsKey).ContinueWith(
                    taskwithmsg =>
                        {

                          HttpResponseMessage response = taskwithmsg.Result;

                            // Read response asynchronously as JsonValue and write out top facts for each country 
                            //response.Content.ReadAsAsync<JArray>().ContinueWith(
                            //    (readTask) =>
                            //    {
                            //        Console.WriteLine("First 50 countries listed by The World Bank...");
                            //        foreach (var country in readTask.Result[1])
                            //        {
                                        
                            //        }
                            //    }); 

                            //response.Content.ReadAsAsync<List<Customer>>().ContinueWith(
                            //    readTask => { model = readTask.Result; });
                        }).ContinueWith(Errorhandler).Wait();
        }





        // Generic logger if something happens
        private static void Errorhandler(Task task)
        {
            if (task.Exception != null)
            {
                Console.WriteLine("Exception {0}", task.Exception);
            }
        }
    }
}
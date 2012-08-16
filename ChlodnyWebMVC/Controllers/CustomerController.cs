namespace ChlodnyWebMVC.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using DomainClasses.EntitiesChinook;

    public class CustomerController : Controller
    {
        // GET: /Customer/
        public ActionResult Index()
        {
            // uses new HttpClient
            var model = new List<Customer>();
            var client = new HttpClient();
            client.GetAsync("http://localhost:60025/api/customer").ContinueWith(
                taskwithmsg =>
                    {
                        HttpResponseMessage response = taskwithmsg.Result;

                        response.Content.ReadAsAsync<List<Customer>>().ContinueWith(
                            readTask => { model = readTask.Result; });
                    }).ContinueWith(Errorhandler).Wait();

            return View(model);
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

// Add to PostAsync calls, will throw an alert if the status code is not successful.
// .ContinueWith((response) =>
//                        { response.Results.EnsureSuccessStatusCode(); }).ContinueWith().ContinueWith(Errorhandler)
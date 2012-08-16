namespace ChlodnyWebApi.Controllers
{
    using System.Web.Mvc;

    using BingServices.BingMaps;

    using ChlodnyWebApi.Models;

    public class DashboardController : Controller
    {
        private readonly IDashboardRepository dashboardRepository;

        private readonly GeoLocation bingServices = new GeoLocation();

        public DashboardController() : this(new DashboardRepository())
        {
        }

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            this.dashboardRepository = dashboardRepository;
        }

        // GET: /Dashboard/
        public ActionResult Index()
        {
            dashboardRepository.PopulateGeoLocation();


            return View();
        }

    }
}

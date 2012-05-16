namespace ChlodnyWebApi
{
    using System.Data.Entity;
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using ChlodnyWebApi.Formatter;

    using DataAccess;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // This is the default Web Api control format
            //routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //    );

            routes.MapHttpRoute(
                name: "RestPCApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { action = RouteParameter.Optional });

            // adds RPC style support to Web Api this allows a controller to host multiple jsonp 
          //  routes.MapHttpRoute(name: "DefaultRPC", routeTemplate: "services/{controller}/{action}");


            // This is the default MVC control fomrat
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

            // this addes jsonp support formatter
          //  GlobalConfiguration.Configuration.Formatters.Clear();
          //  GlobalConfiguration.Configuration.Formatters.Add(new JsonpMediaTypeFormatter());
        }

        protected void Application_Start()
        {
#if DEBUG
            // Only allow migration for debug mode
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChinookContext, DataAccess.Migrations.Configuration>());
#else // turn off migration migration for production
             Database.SetInitializer<ChinookContext>(null);
#endif
            
            AreaRegistration.RegisterAllAreas();
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            BundleTable.Bundles.RegisterTemplateBundles();
        }
    }
}
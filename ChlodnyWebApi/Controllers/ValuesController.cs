using System.Net;

namespace ChlodnyWebApi.Controllers
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web.Http;

    // setting up for JSONP Demo
    public class ValuesController : ApiController
    {
        //public HttpResponseMessage<JsonPReturn> Get(int id, string callback)
        // Changed for Web Api RC
        // GET /api/values/5
        public HttpResponseMessage Get(int id, string callback)
        {
            return Request.CreateResponse(HttpStatusCode.Created, "{'id':'" + id.ToString(CultureInfo.InvariantCulture) + "','data':'Hello JSONP'}");

            //var ret =
            //    new HttpResponseMessage<JsonPReturn>(
            //        new JsonPReturn
            //            {
            //                CallbackName = callback,
            //                Json = "{'id':'" + id.ToString(CultureInfo.InvariantCulture) + "','data':'Hello JSONP'}"
            //            });

            //ret.Content.Headers.ContentType = new MediaTypeHeaderValue("application/javascript");
            //return ret;
        }

        public class JsonPReturn
        {
            public string CallbackName { get; set; }

            public string Json { get; set; }
        }
    }
}
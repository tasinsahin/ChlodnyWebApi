using System.Net;

namespace ChlodnyWebApi.Controllers
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web;
    using System.Web.Http;

    using ChlodnyWebApi.Models;

    // setting up for JSONP Demo
    public class ValuesController : ApiController
    {
        //public HttpResponseMessage<JsonPReturn> Get(int id, string callback)
        // Changed for Web Api RC
        // GET /api/values/5
        public string Get()
        {
            var _response = new JsonResponseMessage();
        var jSearializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            _response.IsSucess = true;
            _response.Message = string.Empty;
            _response.CallBack = string.Empty;
            _response.ResponseData = "This is a test";





            //context.Response.Write(jSearializer.Serialize(_response));
            // return Request.CreateResponse(HttpStatusCode.Created, "{'id':'" + id.ToString(CultureInfo.InvariantCulture) + "','data':'Hello JSONP'}");

            //var ret =
            //    new HttpResponseMessage<JsonPReturn>(
            //        new JsonPReturn
            //            {
            //                CallbackName = callback,
            //                Json = "{'id':'" + id.ToString(CultureInfo.InvariantCulture) + "','data':'Hello JSONP'}"
            //            });

            //ret.Content.Headers.ContentType = new MediaTypeHeaderValue("application/javascript");
            //return ret;
            return jSearializer.Serialize(_response);
        }

        public class JsonPReturn
        {
            public string CallbackName { get; set; }

            public string Json { get; set; }
        }
    }
}
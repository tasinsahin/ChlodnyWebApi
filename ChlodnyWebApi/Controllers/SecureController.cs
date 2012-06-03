using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;

namespace ChlodnyWebApi.Controllers
{
    public class SecureController : ApiController
    {
        [Authorize]
        public string Get()
        {
            return System.Threading.Thread.CurrentPrincipal.Identity.Name;
            
            // GetUserPrincipal no longer used
            // return this.Request.GetUserPrincipal().Identity.Name;

            // return new string[] { "value1", "value2" };
        }

        // GET /api/secure/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/secure
        public void Post(string value)
        {
        }

        // PUT /api/secure/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/secure/5
        public void Delete(int id)
        {
        }
    }
}

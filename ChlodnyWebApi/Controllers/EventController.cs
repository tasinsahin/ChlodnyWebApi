using System.Net;
using System.Net.Http;

namespace ChlodnyWebApi.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using DataAccess;
    using DataAccess.Entities;

    public class EventController : ApiController
    {
        private readonly ChinookContext contextsEvents = new ChinookContext();

        // GET /api/event
        public IEnumerable<Event> Get()
        {
            var events = contextsEvents.Events;
            return events;

            //return this.contexts1.Events;
        }

        // GET /api/event/5
        public string Get(int id)
        {
            return "value";
        }

        // POST /api/event
        public void Post(string value)
        {
        }

        // PUT /api/event/5
        public void Put(int id, string value)
        {
        }

        // DELETE /api/event/5
        public void Delete(int id)
        {
        }
    }
}

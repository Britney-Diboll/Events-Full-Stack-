using Events.Data;
using Events.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Events.ViewModels;
using System.Data.Entity;

namespace Events.Controllers
{
    public class EventController : ApiController
    {
        public IEnumerable<Event> GetEvents()
        {
            var db = new EventContext();

            var search = db.Events.Include(x => x.Attendees);

            return search.ToList();
        }

        public IHttpActionResult GetOne(int id)
        {
            using (var db = new EventContext())
            {
                var occasion = db.Events
                    //.Include(x => x.Cities)
                    //.Include(x => x.Attendees)
                    .SingleOrDefault(x => x.ID == id);
                if (occasion == null)
                {
                    return NotFound();
                }else
                {
                    return Ok(occasion);
                }
            }
        }
    }
}

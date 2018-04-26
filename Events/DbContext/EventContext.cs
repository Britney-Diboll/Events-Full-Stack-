using Events.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Events.Data
{
    public class EventContext :DbContext
    {
        public EventContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
    }
}
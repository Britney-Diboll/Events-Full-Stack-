using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events.Models
{
    public class Event
    {
        public Event()
        {
            this.Attendees = new HashSet<Attendee>();
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Tagline { get; set; }
        public string LongDescription { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string AgeLimit { get; set; }
        public decimal Price { get; set; }
        public DateTime DateHappening { get; set; }

        public int? CityID { get; set; }
        public City Cities { get; set; }

        public virtual ICollection<Attendee> Attendees { get; set; }

    }
}
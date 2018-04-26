using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Events.Models
{
    public class Attendee
    {

        public Attendee()
        {
            this.Events = new HashSet<Event>();
        }
        public int ID { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
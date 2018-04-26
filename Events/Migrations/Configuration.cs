namespace Events.Migrations
{
    using Events.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Events.Data.EventContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Events.Data.EventContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var PROburg = new City
            {
                Name = "PROburg"
            };

            context.Cities.AddOrUpdate(x => x.Name, PROburg);

            var events = new List<Event>
            {
                new Event
                { Title = "Mid-Night Showing: Rocky Horror Picture Show",
                  Tagline = "Dream it in your living room... Be it in the theater!",
                  LongDescription = "Watch your favorie cult classic in the middle of the night with other 'creatures of the night'!",
                  Address = "1234 Fake Street", CityID = PROburg.ID, State = "FLO-rida",
                    ZIP = "66666", AgeLimit = "18+", Price = 12.00m, DateHappening = new DateTime(2018, 5, 4)},

                new Event
                { Title = "Mid-Night Showing: The Room",
                  Tagline = "Experience this quirky new black comedy, it's a riot!",
                  LongDescription = "Come and throw spoons. You will laugh, cry but we promise not to tear you apart! (BYO-Spoons)",
                  Address = "1234 Fake Street", CityID = PROburg.ID, State = "FLO-rida", ZIP = "66666", AgeLimit = "18+",
                  Price = 10.00m, DateHappening = new DateTime(2018, 5, 11)},

                new Event
                { Title = "Marvel Movie Marathon",
                  Tagline = "Watch all Marvel Movies in order - non stop!",
                  LongDescription = "Every single Marvel movie back to back. Come prepared to nerd out", Address = "987 Slick Street",
                  CityID = PROburg.ID, State = "FLO-rida", ZIP = "66676", AgeLimit = "13+",
                  Price = 50.00m, DateHappening = new DateTime(2018, 6, 1)},

                new Event
                { Title = "Star Wars Movie Marathon",
                  Tagline = "Nerd out while watching all Star Wars Movies in order - non stop!",
                  LongDescription = "STARRRRRRRR WARRRRRSSSSSSSSSS", Address = "987 Fake Street",
                  CityID = PROburg.ID, State = "FLO-rida", ZIP = "66676", AgeLimit = "18+",
                  Price = 30.00m, DateHappening = new DateTime(2018, 6, 8),
                  
                }
            };

            events.ForEach(e =>
            {
                context.Events.AddOrUpdate(a => a.Title, e);
            });

            var attendees = new List<Attendee>
            {

            };

            context.SaveChanges();
        }
    }
}

namespace Events.Migrations
{
    using Events.Models;
    using System;
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
            context.SaveChanges();
        }
    }
}

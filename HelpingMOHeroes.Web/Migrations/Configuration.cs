namespace HelpingMOHeroes.Web.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HelpingMOHeroes.Web.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HelpingMOHeroes.Web.DAL.HelpingMOHeroesDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HelpingMOHeroes.Web.DAL.HelpingMOHeroesDb context)
        {
            //  This method will be called after migrating to the latest version.

            var clients = new List<Client>
            {
                new Client{LastName="Doe",FirstName="John",AddDate=DateTime.Parse("2016-02-28")}
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var locations = new List<Location>
            {
                new Location{LocationName="Location 1",Address="12345 Main St",Address2="",City="Kansas City",State="MO",ZIP="64154",AddDate=DateTime.Parse("2016-02-28")}
            };
            locations.ForEach(l => context.Locations.Add(l));
            context.SaveChanges();

            var events = new List<Event>
            {
                new Event{LocationId=1,NumSlots=10,EventDate=DateTime.Parse("2016-02-28")}
            };
            events.ForEach(e => context.Events.Add(e));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{EventId=1,ClientId=1}
            };
            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HelpingMOHeroes.Web.Models;

namespace HelpingMOHeroes.Web.DAL
{
    public class EventInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var clients = new List<Client>
            {
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")},
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")},
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")},
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")},
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")},
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")},
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")},
                new Client{LastName="",FirstName="",AddDate=DateTime.Parse("")}
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

            var events = new List<Event>
            {
                new Event{},
            };
            events.ForEach(e => context.Events.Add(e));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{}
            };
            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}
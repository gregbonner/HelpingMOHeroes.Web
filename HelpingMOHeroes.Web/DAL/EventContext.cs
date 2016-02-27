using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HelpingMOHeroes.Web.Models;

namespace HelpingMOHeroes.Web.DAL
{
    public class EventContext : DbContext
    {

        public EventContext() : base("EventContext")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
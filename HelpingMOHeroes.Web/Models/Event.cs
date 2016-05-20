using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpingMOHeroes.Web.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int NumSlots { get; set; }
        public DateTime EventDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual Location Location { get; set; }
    }
}
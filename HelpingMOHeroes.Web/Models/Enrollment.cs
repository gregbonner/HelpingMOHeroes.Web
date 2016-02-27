using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpingMOHeroes.Web.Models
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int EventId { get; set; }
        public int ClientId { get; set; }

        public virtual Event Event { get; set; }
        public virtual Client Client { get; set; }
    }
}
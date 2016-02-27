using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpingMOHeroes.Web.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime AddDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
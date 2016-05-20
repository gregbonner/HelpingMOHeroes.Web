using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpingMOHeroes.Web.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public DateTime AddDate { get; set; }

    }
}
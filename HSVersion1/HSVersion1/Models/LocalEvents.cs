using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSVersion1.Models
{
    public class LocalEvents
    {
        public int Id { get; set; }
        public string Event { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
    }
}
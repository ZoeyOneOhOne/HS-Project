using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSVersion1.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
    }
 
}
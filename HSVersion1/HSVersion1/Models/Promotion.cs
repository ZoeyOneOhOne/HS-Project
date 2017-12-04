using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSVersion1.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Shop { get; set; }
        public string Deal { get; set; }
        public DateTime Time { get; set; }
    }
}
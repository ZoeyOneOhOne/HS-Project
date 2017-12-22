using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace HSVersion1.Models
{
    public class BakeryMenu
    {
        public int ID { get; set; } 
        public string Item { get; set; }
        public string Description { get; set; }
        public SqlMoney Price { get; set; }
    }
}
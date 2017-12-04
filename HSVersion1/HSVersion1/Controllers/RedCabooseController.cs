using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HSVersion1.Models;


namespace HSVersion1.Controllers
{
    public class RedCabooseController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: RedCaboose
        public ActionResult Index()
        {
            var redPromos = db.Promotion.Where(b => b.Shop == "The Red Caboose").ToList();
            return View(redPromos);
        }
    }
}
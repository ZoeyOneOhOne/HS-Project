using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HSVersion1.Models;

namespace HSVersion1.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Users
        public ActionResult Index()
        {
            db.Users.ToList();
            var users = db.Users.ToString();
            return View(users);
        }
    }
}
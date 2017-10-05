using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HSVersion1.Models;

namespace HSVersion1.Controllers
{
    public class ShopsController : Controller
    {
        private ApplicationDbContext _dbContext;

        public ShopsController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Shops
        public ActionResult Index()
        {
            var shops = _dbContext.Shops.ToList();
            return View(shops);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            var shop = _dbContext.Shops.SingleOrDefault(v => v.Id == id);

            if (shop == null)
                return HttpNotFound();

            return View(shop);
        }

        public ActionResult Delete(int id)
        {
            var shop = _dbContext.Shops.SingleOrDefault(v => v.Id == id);

            if (shop == null)
                return HttpNotFound();

            return View(shop);
        }

        [HttpPost]
        public ActionResult Update(Shop shop)
        {
            var shopInDb = _dbContext.Shops.SingleOrDefault(v => v.Id == shop.Id);

            if (shopInDb == null)
                return HttpNotFound();

            shopInDb.Name = shop.Name;
            shopInDb.Description = shop.Description;
            shopInDb.Hours = shop.Hours;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DoDelete(int id)
        {
            var video = _dbContext.Shops.SingleOrDefault(v => v.Id == id);
            if (video == null)
                return HttpNotFound();
            _dbContext.Shops.Remove(video);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
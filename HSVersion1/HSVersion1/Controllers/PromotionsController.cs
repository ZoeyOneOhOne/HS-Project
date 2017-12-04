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
   
    public class PromotionsController : Controller
    {
        private ApplicationDbContext _dbContext = new ApplicationDbContext();

        // GET: Promotions
        public ActionResult IndexPartial()
        {
            var promotions = _dbContext.Promotion.ToList();
            return View(promotions);
        }

        // ADD a new promotion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult New([Bind(Include = "Id,Shop,Deal,Time")] Promotion promotion)

        {
            if (ModelState.IsValid)
            {
                _dbContext.Promotion.Add(promotion);
                _dbContext.SaveChanges();
                return RedirectToAction("IndexPartial");
            }

            return View(promotion);
        }

        public ActionResult Edit(int? id)
        {
            var promotion = _dbContext.Promotion.SingleOrDefault(v => v.Id == id);

            if (promotion == null)
                return HttpNotFound();

            return View(promotion);
        }

        [HttpPost]
        public ActionResult Update(Promotion promotion)
        {
            var promotionInDb = _dbContext.Promotion.SingleOrDefault(v => v.Id == promotion.Id);

            if (promotionInDb == null)
                return HttpNotFound();

            promotionInDb.Shop = promotion.Shop;
            promotionInDb.Deal = promotion.Deal;
            promotionInDb.Time = promotion.Time;
            _dbContext.SaveChanges();

            return RedirectToAction("IndexPartial");
        }

        public ActionResult Delete(int? id)
        {
            var promotion = _dbContext.Promotion.SingleOrDefault(v => v.Id == id);

            if (promotion == null)
                return HttpNotFound();

            return View(promotion);
        }

        [HttpPost]
        public ActionResult DoDelete(int? id)
        {
            var video = _dbContext.Promotion.SingleOrDefault(v => v.Id == id);
            if (video == null)
                return HttpNotFound();
            _dbContext.Promotion.Remove(video);
            _dbContext.SaveChanges();
            return RedirectToAction("IndexPartial");
        }
    }
}
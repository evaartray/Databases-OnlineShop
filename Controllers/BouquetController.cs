using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class BouquetController : Controller
    {
        private static List<Bouquet> bouquets = new List<Bouquet>
        {
            new Bouquet(1, "Spring lilac and roses bouquet", 299),
            new Bouquet(2, "Summer Joy bouquet", 219),
            new Bouquet(3, "Purple dream bouquet", 301)
            
        };

        // GET: Bouquet
        public ActionResult Index()
        {
            return View(bouquets);
        }

        // GET: Bouquet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bouquet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bouquet/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bouquet/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var bouquet = bouquets.Single(obj => obj.BouquetId == id);
            return View(bouquet);
        }

        // POST: Bouquet/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                bouquets.Single(obj => obj.BouquetId == id).Name = collection["Name"];


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bouquet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bouquet/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

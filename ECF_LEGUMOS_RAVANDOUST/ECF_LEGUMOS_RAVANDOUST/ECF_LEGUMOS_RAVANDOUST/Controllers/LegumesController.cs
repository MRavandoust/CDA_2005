using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECF_LEGUMOS_RAVANDOUST.Models;

namespace ECF_LEGUMOS_RAVANDOUST.Controllers
{
    public class LegumesController : Controller
    {

        LegumesDBContext ctx;

        public LegumesController(LegumesDBContext ctx)
        {
            this.ctx = ctx;
        }

        // GET: LegumesController
        public ActionResult Index()
        {
            List<Vegetable> vegetable = ctx.Vegetables.ToList();
            return View(vegetable);
        }



        // GET: LegumesController/Details/5
        public ActionResult Details()
        {
            var item = ctx.Vegetables.ToList();
            var it = item[item.Count - 1];
            Vegetable vegetable = ctx.Vegetables.SingleOrDefault(x => x.Id == it.Id);
            return View(vegetable);
        }

        // GET: LegumesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LegumesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vegetable vegetable)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Vegetables.Add(vegetable);
                    ctx.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(vegetable);
            }
            catch
            {
                return View(vegetable);
            }
        }

        // GET: LegumesController/Edit/5
        public ActionResult Edit(int id)
        {
            Vegetable vegetable = ctx.Vegetables.SingleOrDefault(x => x.Id == id);
            return View(vegetable);
        }

        // POST: LegumesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Vegetable vegetable)
        {
            Vegetable vegetables = ctx.Vegetables.SingleOrDefault(x => x.Id == id);
            try
            {
                if(vegetables != null)
                {
                    vegetables.Name = vegetable.Name;
                    vegetables.Variety = vegetable.Variety;
                    vegetables.PrimaryColor = vegetable.PrimaryColor;
                    vegetables.LifeTime = vegetable.LifeTime;
                    vegetables.Fresh = vegetable.Fresh;
                    ctx.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LegumesController/Delete/5
        public ActionResult Delete(int id)
        {
            Vegetable vegetables = ctx.Vegetables.SingleOrDefault(x => x.Id == id);
            return View(vegetables);
        }

        // POST: LegumesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Vegetable vegetables = ctx.Vegetables.SingleOrDefault(x => x.Id == id);
            try
            {
                if(vegetables != null)
                {
                    ctx.Vegetables.Remove(vegetables);
                    ctx.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}

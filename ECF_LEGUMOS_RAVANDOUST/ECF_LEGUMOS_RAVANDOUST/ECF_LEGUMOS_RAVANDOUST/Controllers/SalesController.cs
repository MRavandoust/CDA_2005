using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECF_LEGUMOS_RAVANDOUST.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECF_LEGUMOS_RAVANDOUST.Controllers
{
    public class SalesController : Controller
    {

        LegumesDBContext ctx;

        public SalesController(LegumesDBContext ctx)
        {
            this.ctx = ctx;
        }

        // GET: SalesController
        public ActionResult Index()
        {
            IEnumerable<Sale> sales = ctx.Sales.ToList();

            foreach(Sale sale in sales)
            {
                sale.Vegetable = ctx.Vegetables.FirstOrDefault(item => item.Id == sale.VegetableId);

            }
            
            return View(sales);
        }

       


        // GET: SalesController/Details/5
        public ActionResult Details()
        {

            var item = ctx.Sales.ToList();
            var it = item[item.Count - 1];
            Sale sale = ctx.Sales.SingleOrDefault(x => x.SaleId == it.SaleId);
            return View(sale);
        }



        // GET: SalesController/Create
        public ActionResult Create()
        {
            ViewBag.VegetableId = new SelectList(ctx.Vegetables, "Id", "Name");
            return View();
        }

        // POST: SalesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sale sale)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Sales.Add(sale);
                    ctx.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.VegetableId = new SelectList(ctx.Vegetables, "Id", "Name");
                return View(sale);
            }
            catch
            {
                return View(sale);
            }
        }

        // GET: SalesController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.VegetableId = new SelectList(ctx.Vegetables, "Id", "Name");
            Sale sale = ctx.Sales.SingleOrDefault(x => x.SaleId == id);
            return View(sale);
        }

        // POST: SalesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Sale sale)
        {
            ViewBag.VegetableId = new SelectList(ctx.Vegetables, "Id", "Name");
            Sale sales = ctx.Sales.SingleOrDefault(x => x.SaleId == id);
            try
            {
                if (sales != null)
                {
                    sales.SaleDate = sale.SaleDate;
                    sales.SaleWeight = sale.SaleWeight;
                    sales.SaleUnitPrice = sale.SaleUnitPrice;
                    sales.SaleActive = sale.SaleActive;
                    ctx.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalesController/Delete/5
        public ActionResult Delete(int id)
        {
            Sale sales = ctx.Sales.SingleOrDefault(x => x.SaleId == id);
            return View(sales);
        }

        // POST: SalesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Sale sales = ctx.Sales.SingleOrDefault(x => x.SaleId == id);
            try
            {
                if (sales != null)
                {
                    ctx.Sales.Remove(sales);
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

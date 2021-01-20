using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeLance.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FreeLance.Controllers
{
    public class QuotesController : Controller
    {

        FreeDBContext ctx;

        public QuotesController(FreeDBContext ctx)
        {
            this.ctx = ctx;
        }

        // GET: QuotesController
        public ActionResult Index()
        {
            List<Quote> quotes = ctx.Quotes.ToList();
            return View(quotes);
        }

        // GET: QuotesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuotesController/Create
        public ActionResult Create()
        {
            ViewBag.JobId = new SelectList(ctx.Jobs, "JobId", "JobState"); 
            return View();
        }

        // POST: QuotesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quote quote)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                ctx.Quotes.Add(quote);
                ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
                }
                ViewBag.JobId = new SelectList(ctx.Jobs, "JobId", "JobState", quote.JobId);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(quote);
            }
        }

        // GET: QuotesController/Edit/5
        public ActionResult Edit(int id)
        {
            Quote quote = ctx.Quotes.SingleOrDefault(q => q.QuoteId == id);
            return View(quote);
        }

        // POST: QuotesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Quote quote)
        {
            Quote quotes = ctx.Quotes.SingleOrDefault(q => q.QuoteId == id);
            try
            {
                if(quotes != null)
                {
                    quotes.QuoteState = quote.QuoteState;
                    quotes.QuoteDate = quote.QuoteDate;
                    quotes.QuoteAmount = quote.QuoteAmount;
                    quotes.QuoteFinalDate = quote.QuoteFinalDate;
                    quotes.QuoteFinalAmount = quote.QuoteFinalAmount;
                    ctx.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuotesController/Delete/5
        public ActionResult Delete(int id)
        {
            Quote quote = ctx.Quotes.SingleOrDefault(q => q.QuoteId == id);
           
            return View("Delete", quote);
        }

        // POST: QuotesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Quote quote = ctx.Quotes.SingleOrDefault(q => q.QuoteId == id);
            try
            {
                ctx.Remove(quote);
                ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

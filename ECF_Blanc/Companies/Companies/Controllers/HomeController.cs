using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Companies.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Companies.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext ctx;

        public HomeController(CompanyContext ctx)
        {
            this.ctx = ctx;
        }


        public IActionResult Index()
        {

            IEnumerable<Company> companies = ctx.Companies.ToList();
            ViewBag.Id = new SelectList(ctx.Companies, "Id");
            return View("Index", companies);
        }


        // GET: QuotesController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: QuotesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    ctx.Companies.Add(company);
                    ctx.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View(company);
            }
            catch
            {
                return View(company);
            }
        }

        // GET: QuotesController/Edit/5
        public ActionResult Edit(int id)
        {
            Company company = ctx.Companies.SingleOrDefault(q => q.Id == id);
            return View(company);
        }

        // POST: QuotesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Company company)
        {
            Company companies = ctx.Companies.SingleOrDefault(q => q.Id == id);
            try
            {
                if (companies != null)
                {
                    companies.Id = company.Id;
                    companies.Name = company.Name;
                    companies.City = company.City;
                    companies.ContactName = company.ContactName;
                    companies.ContactEmail = company.ContactEmail;
                    companies.ContactPhone = company.ContactPhone;
                    companies.DateAdd = company.DateAdd;
                    companies.DateUpdate = company.DateUpdate;
                    companies.Comment = company.Comment;
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
            Company company = ctx.Companies.SingleOrDefault(q => q.Id == id);

            return View("Delete", company);
        }

        // POST: QuotesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Company company = ctx.Companies.SingleOrDefault(q => q.Id == id);
            try
            {
                ctx.Remove(company);
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

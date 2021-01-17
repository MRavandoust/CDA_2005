using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeLance.Models;

namespace FreeLance.Controllers
{
    public class ClientsController : Controller
    {
        FreeDBContext ctx;

        public ClientsController(FreeDBContext ctx)
        {
            this.ctx = ctx;
        }

        //GET: ClientsController
        public ActionResult Index()
        {
            //ctx.Customers.Add(new Customer { Name = "Masoud", Email = "akam_50@yahoo.com" });
            IEnumerable<Customer> customers = ctx.Customers.ToList();
            return View("CustomersList", customers);
        }


        //public string Index()
        //{
        //    return "Clients";
        //}

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Customer customer)
        {
            try
            {
                ctx.Customers.Add(customer);
                await ctx.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(customer);
            }
        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = ctx.Customers.SingleOrDefault(x => x.Id == id);
            return View("Edit",customer);
        }

        // POST: ClientsController/Edit/5


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            Customer customers = ctx.Customers.SingleOrDefault(x => x.Id == customer.Id);
            
            try
            {
                if (customers != null)
                {
                    customers.Name = customer.Name;
                    customers.Email = customer.Email;
                    ctx.SaveChanges();
                    
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            Customer customer = ctx.Customers.SingleOrDefault(x => x.Id == id);
            return View(customer);
        }

        // POST: ClientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Customer customer = ctx.Customers.SingleOrDefault(x => x.Id == id);
            
            try
            {
                ctx.Customers.Remove(customer);
                ctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        //======================================== Search Action ===================================

        public ActionResult SearchForName(string phrase)
        {
            var customer = from c in ctx.Customers where c.Name.Contains(phrase) select c;

            return View("Index", customer);
        }
    }
}

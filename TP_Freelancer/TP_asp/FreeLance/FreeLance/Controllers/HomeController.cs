using FreeLance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FreeLance.Controllers
{
    public class HomeController : Controller
    {
        FreeDBContext ctx;

        public HomeController(FreeDBContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            IEnumerable<Customer> customers = ctx.Customers.ToList();
            return View("Index", customers);
            
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

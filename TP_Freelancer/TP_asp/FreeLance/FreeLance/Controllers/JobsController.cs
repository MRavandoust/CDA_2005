using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeLance.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FreeLance.Controllers
{
    public class JobsController : Controller
    {

        FreeDBContext jctx;

        public JobsController(FreeDBContext jctx)
        {
            this.jctx = jctx;
        }
        // GET: JobsController
        public ActionResult Index()
        {
            //_context.Invoices.Include(x => x.Users).Include(x => x.Food).ToList();
            //Job job = jctx.Jobs.SingleOrDefault(j => j.JobId == id);
            //List<Job> jobs = jctx.Jobs.Include(x => x.JobState).Include(x => x.JobTitle).Include(x => x.JobStart).Include(x => x.JobEnd).Include(x => x.JobDescription).Include(x => x.CustomerId).ToList();



            List<Job> jobs = jctx.Jobs.ToList();
            return View(jobs);
        }

        // GET: JobsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobsController/Create
        public ActionResult Create()
        {
            ViewBag.CustomerId = new SelectList(jctx.Customers, "Id", "Name");
            return View();
        }

        // POST: JobsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Job job)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    jctx.Jobs.Add(job);
                    jctx.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                ViewBag.CustomerId = new SelectList(jctx.Customers, "Id", "Name", job.CustomerId);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(job);
            }
        }

        // GET: JobsController/Edit/5
        public ActionResult Edit(int id)
        {
            Job job = jctx.Jobs.SingleOrDefault(j => j.JobId == id);
            return View("Edit", job);
        }

        // POST: JobsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Job job)
        {
            Job jobs = jctx.Jobs.SingleOrDefault(j => j.JobId == id);
            try
            {
                if (jobs != null)
                {
                    jobs.JobState = job.JobState;
                    jobs.JobTitle = job.JobTitle;
                    jobs.JobStart = job.JobStart;
                    jobs.JobEnd = job.JobEnd;
                    jobs.JobDescription = job.JobDescription;
                    jctx.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JobsController/Delete/5
        public ActionResult Delete(int id)
        {
            Job job = jctx.Jobs.SingleOrDefault(j => j.JobId == id);
            
            return View(job);
        }

        // POST: JobsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            Job job = jctx.Jobs.SingleOrDefault(j => j.JobId == id);
            try
            {
                jctx.Remove(job);
                jctx.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

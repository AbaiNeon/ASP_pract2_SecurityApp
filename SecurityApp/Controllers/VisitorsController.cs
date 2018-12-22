using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SecurityApp;
using SecurityApp.Models;

namespace SecurityApp.Controllers
{
    public class VisitorsController : Controller
    {
        private SecurityContext db = new SecurityContext();

        // GET: Visitors
        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Заголовок страницы";
            ViewBag.BlaBla = "бла бла";
            ViewBag.CurDate = DateTime.Now;


            return View(await db.visitors.ToListAsync());
        }

        // GET: Visitors/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor = await db.visitors.FindAsync(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // GET: Visitors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visitors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FullName,IIN")] Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                visitor.Id = Guid.NewGuid();
                db.visitors.Add(visitor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(visitor);
        }

        // GET: Visitors/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor = await db.visitors.FindAsync(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // POST: Visitors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FullName,IIN")] Visitor visitor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(visitor);
        }

        // GET: Visitors/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitor visitor = await db.visitors.FindAsync(id);
            if (visitor == null)
            {
                return HttpNotFound();
            }
            return View(visitor);
        }

        // POST: Visitors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            Visitor visitor = await db.visitors.FindAsync(id);
            db.visitors.Remove(visitor);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

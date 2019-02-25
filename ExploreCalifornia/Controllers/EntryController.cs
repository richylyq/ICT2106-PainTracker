using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.Models;
using ExploreCalifornia.Data;

namespace ExploreCalifornia.Controllers
{
    public class EntryController : Controller
    {

        internal DataGateway<Entry> dataGateway;
        internal AreaGateway areaGateway;

        public EntryController(DiaryContext context)
        {
            dataGateway = new EntryGateway(context);
            areaGateway = new AreaGateway(context);

        }
        // GET: Entry
        public ActionResult Index()
        {
            return View(dataGateway.SelectAll());
        }

        // GET: Entry/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Entry entry = dataGateway.SelectById(id);
            //do something here
            string name = "";
            foreach (var item in areaGateway.SelectByEntryId(id))
            {
                name += item.Test;
            }
            if (name != null)
            {
                ViewBag.id = name;
            }
            else
            {
                ViewBag.id = "oops";
            }
            
            //ViewBag.id = entry.Areas.First().Test;
            if (entry == null)
            {
                return NotFound();
            }
            return View(entry);
        }

        // GET: Entry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entry/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Entry entry)
        {
            try
            {
                // TODO: Add insert logic here
                dataGateway.Insert(entry);
                return RedirectToAction(nameof(Details), new { id = entry.EntryID });
            }
            catch
            {
                return View();
            }
        }

        // GET: Entry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Entry/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Entry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Entry/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                dataGateway.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult View(int id)
        {
            Entry selected = new Entry();
            selected = dataGateway.SelectById(id);
            return View(selected);
        }

    }
}
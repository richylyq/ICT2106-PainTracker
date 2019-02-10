using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.Controllers
{
    public class EntryController : Controller
    {

        static List<Entry> model = new List<Entry>();
        static bool uploaded = false;

        // GET: Entry
        public ActionResult Index()
        {
            if (!uploaded)
            {
                var entry1 = new Entry();
                entry1.entryID = 1;
                entry1.title = "PAIN!";
                entry1.creationDate = new DateTime(2020, 12, 10);

                var entry2 = new Entry();
                entry2.entryID = 2;
                entry2.title = "NOT PAIN!";
                entry2.creationDate = new DateTime(2020, 12, 11);

                var entry3 = new Entry();
                entry3.entryID = 3;
                entry3.title = "VERY PAIN!";
                entry3.creationDate = new DateTime(2020, 12, 15);

                var entry4 = new Entry();
                entry4.entryID = 4;
                entry4.title = "NUMB!";
                entry4.creationDate = new DateTime(2020, 12, 30);

                model.Add(entry1);
                model.Add(entry2);
                model.Add(entry3);
                model.Add(entry4);
                uploaded = true;
            }
            return View(model);
        }

        // GET: Entry/Details/5
        public ActionResult Details(int id)
        {
            Entry selected = new Entry();
            foreach (Entry entry in model)
            {
                if (entry.entryID == id)
                {
                    selected = entry;
                    break;
                }
            }
            return View(selected);
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
                model.Add(entry);
                return RedirectToAction(nameof(Details), new { id = entry.entryID });
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
            Entry selected = new Entry();
            foreach (Entry entry in model)
            {
                if (entry.entryID == id)
                {
                    selected = entry;
                    break;
                }
            }
            return View(selected);
        }

        // POST: Entry/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

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
            foreach (Entry entry in model)
            {
                if (entry.entryID == id)
                {
                    selected = entry;
                    break;
                }
            }
            return View(selected);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        List<Insuree> insurees = new List<Insuree>();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }
        public decimal MonthlyQuote(Insuree insuree)
        {
            decimal monthlyCost = insuree.Quote = 50;
            
            if (insuree.DateOfBirth < new DateTime(2004))
            {
                monthlyCost += 100;
            }
            if (insuree.DateOfBirth >= new DateTime(2003) && insuree.DateOfBirth <= new DateTime(1997))
            {
                monthlyCost += 50;
            }
            if (insuree.DateOfBirth >= new DateTime(1997))
            {
                monthlyCost += monthlyCost + 25;
            }
            if (insuree.CarYear < 2000)
            {
                monthlyCost += monthlyCost + 25;
            }
            if (insuree.CarYear > 2015)
            {
                monthlyCost += monthlyCost + 25;
            }
            if (insuree.CarMake == "Porsche")
            {
                monthlyCost += monthlyCost + 25;
            }
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                monthlyCost += monthlyCost + 25;
            }
            if (insuree.DUI == true)
            {
                monthlyCost += (monthlyCost * 1/4) + monthlyCost;
            }
            if (insuree.CoverageType == true)
            {
                monthlyCost += (monthlyCost * 1/2) + monthlyCost;
            }
            if (insuree.SpeedingTickets > 0)
            {
                int multiply = insuree.SpeedingTickets * 10;
                monthlyCost += monthlyCost + multiply;
            }

            return monthlyCost;
            
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }
        
        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
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
        public ActionResult Admin()
        {
           

            foreach (var insuredPeople in insurees)
            {
                var insuredPerson = new Insuree();
                insuredPerson.Quote = insuredPeople.Quote;
                insuredPerson.FirstName = insuredPeople.FirstName;
                insuredPeople.LastName = insuredPeople.LastName;
                insuredPerson.EmailAddress = insuredPeople.EmailAddress;
                insurees.Add(insuredPerson);
            }
            return View(insurees);
        }
    }
}

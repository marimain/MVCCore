using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCore.Models;

namespace MVCCore.Controllers
{
    public class PatientController : Controller

    {
        public PatientController() { }

        // GET: PatientController
        public ActionResult Index()
        {
            List<PatientDetail> pats = new List<PatientDetail>();

            pats.Add(new PatientDetail { PatientID = 100, FirstName = "Mike", LastName = "Tyson", DOB = Convert.ToDateTime("2021-05-06") });
            pats.Add(new PatientDetail { PatientID = 200, FirstName = "Brind", LastName = "Smith", DOB = Convert.ToDateTime("2016-01-30") });
            pats.Add(new PatientDetail { PatientID = 300, FirstName = "Woo", LastName = "Micrare", DOB = Convert.ToDateTime("1968-12-06") });
            pats.Add(new PatientDetail { PatientID = 400, FirstName = "Lynch", LastName = "William", DOB = Convert.ToDateTime("1998-01-26") });

            PatientMetricsViewModel vm = new PatientMetricsViewModel();
            vm.Patients = pats;
            return View("Index",vm);
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PatientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

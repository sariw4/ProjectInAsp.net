using BE;
using BL;
using Medical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medical.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Patients()
        {
            PatientModel model = new PatientModel();
            var Patients = model.GetPatients();
            return View(Patients);
        }
        // GET: Patient/Details/5
        public ActionResult Prescriptions(int id)
        {
            PatientModel model = new PatientModel();
            var Prescriptions = model.GetPrescriptionsById(id);
            ViewBag.id = id;
            return View(Prescriptions);
        }
        public ActionResult Prescription_(int id)
        {
            TempData["ID"] = id;
            ViewBag.id = id;
            MedicineModel model = new MedicineModel();
            return View(model.GetMedicines()) ;
        }
        [HttpPost]
        public ActionResult Prescription_(FormCollection collection)
        {
            PatientModel model = new PatientModel();
            try
            {
                var x = TempData["ID"];
                model.AddPrescription(x.ToString(), RouteConfig.user.FirstName, RouteConfig.user.LastName, collection["Medicine"], collection["BeginDate"], collection["FinishDate"]);
                return RedirectToAction("Patients");

            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Create
        public ActionResult AddPatient()
        {
            var Model = new PatientModel();
            return View(Model.GetPatients());
        }

        // POST: Patient/Create
        [HttpPost]
        public ActionResult AddPatient(FormCollection collection)
        {
            PatientModel model = new PatientModel();
            try
            {
                model.Add(collection["FirstName"], collection["LastName"], collection["DateofBirth"], collection["Phone"], collection["Email"]);
                return RedirectToAction("Patients");

            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Edit/5
        public ActionResult Edit(int id)
        {
            PatientModel model = new PatientModel();
            var Patient = model.GetPatients().First(m => m.Id == id);
            return View(Patient);
        }

        // POST: Patient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            PatientModel model = new PatientModel();
            try
            {
                model.Update(id, collection["FirstName"], collection["LastName"], collection["DateofBirth"], collection["Phone"], collection["Email"]);
                return RedirectToAction("Patients");
            }
            catch
            {
                return View();
            }
        }

        // GET: Patient/Delete/5
        public ActionResult Delete(int id)
        {
            PatientModel model = new PatientModel();
            model.delete(id);
            return RedirectToAction("Patients");
        }

        // POST: Patient/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

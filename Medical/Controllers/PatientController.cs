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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Patient/Create
        public ActionResult AddPatient()
        {
            var Model = new PatientModel();
            return View(Model.Patients);
        }

        // POST: Patient/Create
        [HttpPost]
        public ActionResult AddPatient(Patient patient)
        {
            //PatientModel model = new PatientModel();
            try
            {
                PatientsLogic bl = new PatientsLogic();
                
                //bl.AddPatient(patient);
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
            var Patient = model.GetPatient(id);
            return View(Patient);
        }

        // POST: Patient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            PatientModel model = new PatientModel();
            try
            {
                model.Update(id, collection["Name"], collection["DateofBirth"], collection["Phone"], collection["Email"]);
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

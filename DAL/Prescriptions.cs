using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Prescriptions
    {
        public void InsertPrescription(Prescription p)
        {
            try
            {
                using (var ctx = new mediDB())
                {
                    ctx.Prescriptions.Add(p);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        public IEnumerable<Prescription> GetPrescriptions()
        {
            try
            {
                List<Prescription> result = new List<Prescription>();
                using (var ctx = new mediDB())
                {
                    foreach (var prescription in ctx.Prescriptions)
                    {
                        result.Add(prescription);
                    }
                }
                return result;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}

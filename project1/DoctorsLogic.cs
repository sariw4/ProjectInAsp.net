using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DoctorsLogic
    {
        DAL.Doctors dal = new DAL.Doctors();
        public void InsertDoctors(Doctor d)
        {
            dal.InsertDoctors(d);
        }
        public void RemoveDoctors(int id)
        {
            dal.RemoveDoctors(id);
        }
        public void UpdateDoctors(Doctor doc, int id)
        {
            dal.UpdateDoctors(doc, id);
        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return dal.GetDoctors();
        }
    }
}



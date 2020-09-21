using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class PatientsLogic
    {
        public void AddPatient( Patient patient)
        {
            //Add your buesiness logic here
            DAL.ReadWriteDrugs dal = new DAL.ReadWriteDrugs();
            dal.InsertPatient(patient);
        }

        //public bool RemovePatients(int id)
        //{
        //    bool result = true;
        //    //Add your buesiness logic here
        //    DAL.ReadWriteDrugs dal = new DAL.ReadWriteDrugs();
        //    dal.RemovePatients(id);
        //    return result;
        //}

    }
}
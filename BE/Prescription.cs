using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Prescription
    {
        public int PatientId { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public Medicine Medicine { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime FinishTime { get; set; }
        public Prescription() { }
        public Prescription(int patientId, string doctorFirstName, string doctorLastName, Medicine medicine, DateTime beginTime, DateTime finishTime)
        {
            PatientId = patientId;
            DoctorFirstName =doctorFirstName;
            DoctorLastName = doctorLastName;
            Medicine = medicine;
            BeginTime = beginTime;
            FinishTime = finishTime;

        }
        public Prescription(Prescription prescription)
        {
            PatientId = prescription.PatientId;
            DoctorFirstName = prescription.DoctorFirstName;
            DoctorLastName = prescription.DoctorLastName;
            Medicine = prescription.Medicine;
            BeginTime = prescription.BeginTime;
            FinishTime = prescription.FinishTime;
        }

    }
}

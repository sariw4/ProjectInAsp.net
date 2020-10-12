using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Prescription
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        [DisplayName ("Doctor First Name")]
        public string DoctorFirstName { get; set; }
        [DisplayName("Doctor Last Name")]
        public string DoctorLastName { get; set; }
        public string Medicine { get; set; }
        [DisplayName("Begin Time")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BeginTime { get; set; }
        [DisplayName("Finish Time")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FinishTime { get; set; }
        public Prescription() { }
        public Prescription(int patientId, string doctorFirstName, string doctorLastName, string medicine, DateTime beginTime, DateTime finishTime)
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

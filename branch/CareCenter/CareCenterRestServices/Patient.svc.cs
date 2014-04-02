using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entities;

namespace CareCenterRestServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PatientService : IPatientService
    {

        public Patient GetPatient(string patientID)
        {
            Patient patient = new Patient();
            patient.Male = true;
            patient.Name = "Jan Kowalski";
            patient.PESEL = 89012838482;
            patient.BirthDate = new DateTime(1989, 01, 28);
            return patient;
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            Patient patient = new Patient();
            patient.Male = true;
            patient.Name = "Jan Kowalski";
            patient.PESEL = 89012838482;
            patient.BirthDate = new DateTime(1989, 01, 28);
            
            Patient patient2 = new Patient();
            patient.Male = true;
            patient.Name = "Paweł Nowak";
            patient.PESEL = 83052438482;
            patient.BirthDate = new DateTime(1983, 05, 24);
            patients.Add(patient);
            patients.Add(patient2);

            return patients;
        }

        public bool AddPatient(Patient patient)
        {
            return true;
        }
    }
}

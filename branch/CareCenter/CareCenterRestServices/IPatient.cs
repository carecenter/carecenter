using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CareCenterRestServices
{
   [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/Patient/{patientID}", Method = "GET", ResponseFormat=WebMessageFormat.Json)]
        Patient GetPatient(string patientID);
        [OperationContract]
        [WebInvoke(UriTemplate = "/Patient/", Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        List<Patient> GetPatients();
        [OperationContract]
        [WebInvoke(UriTemplate = "/Patient/Paa/as", Method = "POST")]
        bool AddPatient(Patient patient);
    }

}

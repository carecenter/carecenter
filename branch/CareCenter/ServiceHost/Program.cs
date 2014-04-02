using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            System.ServiceModel.ServiceHost serviceHost = new System.ServiceModel.ServiceHost(typeof(CareCenterRestServices.PatientService));
            serviceHost.Open();
            Console.WriteLine("Services are ready & running.");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

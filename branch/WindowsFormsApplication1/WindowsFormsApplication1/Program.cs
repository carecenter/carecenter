using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            WebRequest request = WebRequest.Create("http://localhost:9002/CareCenterRestServices/Patient/1");
            WebResponse ws = request.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding(1252);
            StreamReader responseStream = new StreamReader(ws.GetResponseStream());
            string response = responseStream.ReadToEnd();
            responseStream.Close();
            MessageBox.Show(response);
        }
    }
}

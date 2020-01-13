using System;
using System.Windows.Forms;

namespace NYSE.FrontEnd
{
    class Program
    {

        [STAThread]
        static void Main()
        {
            // for the API to run we need to bypass certificates
            System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain()); // show the main menu form
    }

    }
}

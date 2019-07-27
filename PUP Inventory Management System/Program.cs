using PUP_Inventory_Management_System.UI;
using System;
using System.Windows.Forms;

namespace PUP_Inventory_Management_System
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
            Application.Run(new DASHBOARD());
        }
    }
}

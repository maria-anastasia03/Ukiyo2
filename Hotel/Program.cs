using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
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

            intro openingProgram = new intro();
            openingProgram.opening();
            customer userinput = new customer();
            userinput.userData();
            Console.WriteLine("Do you wish to reservate?");
            option myNumber = new option();
            myNumber.choose();
        }
    }
}

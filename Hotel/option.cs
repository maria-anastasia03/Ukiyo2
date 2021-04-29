using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class option
    {
        public void choose()
        {
            Console.WriteLine("1. Yes, i want to reservate\n2. I want to request something\n1/2? ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                typeRoom newsearch = new typeRoom();
                newsearch.chooseOption();
                Console.WriteLine("Do you wish to continue the payment?\nYes/No? ");
                string buy = Console.ReadLine();
                if (buy == "Y" || buy == "y" || buy == "Yes" || buy == "yes")
                {
                    payment pay = new payment();
                    pay.paymentmethod();
                }

                else
                {
                    failInput next = new failInput();
                    next.cont();
                }
            }

            else if (userChoice == 2)
            {
                specialRequest uploadrec = new specialRequest();
                uploadrec.Request();
                failInput next = new failInput();
                next.cont();
            }
            else
            {
                failInput errmsg = new failInput();
                errmsg.failNumber();
                Console.WriteLine("\n____________________________________\n");
                choose();
            }
        }
    }
}

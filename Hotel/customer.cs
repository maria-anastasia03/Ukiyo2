using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class customer
    {
        public void userData()
        {
            Console.Write("Please fill this form to continue\n");
            Console.Write("Name :\t\t");
            string nameCustomer = Console.ReadLine();
            Console.Write("ID Number :\t");
            string idCustomer = Console.ReadLine();
            Console.Write("Email :\t\t");
            string emailCustomer = Console.ReadLine();
            Console.Write("Phone Number :\t");
            string numberCustomer = Console.ReadLine();
        }
    }
}

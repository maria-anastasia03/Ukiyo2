using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class payment
    {
        public void paymentOvo()
        {
            Console.WriteLine("Please transfer your money into +6281388888888 OVO/Gopay account.\nThank you for using our service.\nWe will send your Booking ID within 3 days after payment.\nHope you enjoy your trip.");
        }
        public void paymentcc()
        {
            Console.WriteLine("Please transfer your money to 9999-9999-9999.\nThank you for using our service.\nWe will send your Booking ID within 3 days after payment.\nHope you enjoy your trip.");
        }
        public void paymentcod()
        {
            Console.WriteLine("Thank you for using our service.\nWe will send your Booking ID within 3 days.\nHope you enjoy your trip.");
        }
        public void paymentmethod()
        {
            Console.WriteLine("Please select your payment method:\n1. Cash\n2. Debit\n3. Credit Card\n4.OVO/GoPay");
            int paychoose = Convert.ToInt32(Console.ReadLine());
            if (paychoose == 1)
            {
                paymentcod();
            }
            else if (paychoose == 4)
            {
                paymentOvo();
            }
            else if (paychoose == 2 || paychoose == 3)
            {
                paymentcc();
            }
        }

    }
}

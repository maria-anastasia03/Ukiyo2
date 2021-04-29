using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class specialRequest
    {
        public string typeRoom;
        public int totalRequest;
        public string formatRequest;
        public static int index = 1;
        public void Request()
        {
            Console.WriteLine("What rooms do you want to reservate?");
            typeRoom = Console.ReadLine();

            Console.WriteLine("How many special request do you want?");
            totalRequest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What are those?");

            for (int i = 0; i < totalRequest; i++)
            {
                requests newRequest = new requests()
                {
                    requestName = Console.ReadLine(),
                    requestDescription = Console.ReadLine()
                };
                Console.WriteLine("#{0}.) {1} ({2})", index, newRequest.requestDescription, newRequest.requestName);
                Console.WriteLine("");
                index++;
            }
        }
    }
}

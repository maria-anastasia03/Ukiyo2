using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class typeRoom
    {
        public int hargaRoom;
        public void chooseOption()
        {
            int hargaRoom;
            string standardRoom = "Room size:\t45 m^2\nRoom view:\tCity view\nBed:\t\t1 king bed.\n";
            string deluxeRoom = "Room size:\t65 m^2\nRoom view:\tCity view\nBed:\t\t1 king bed.\n";
            string suiteRoom = "Room size:\t90 m^2\nRoom view:\tCity view\nBed:\t\t1 king bed.\n";
            string executiveRoom = "Room size:\t125 m^2\nRoom view:\tCity view\nBed:\t\t1 king bed.\n";
            string businessRoom = "Room size:\t200 m^2\nRoom view:\tCity view\nBed:\t\t1 king bed.\n";

            Console.WriteLine("What type of room you would like to reservate?");

            string typeRoom = Console.ReadLine();
            if (typeRoom == "1")
            {
                hargaRoom = 1_000_000;
                Console.WriteLine("{0}Price:\t\t{1}", standardRoom, hargaRoom);
            }
            else if (typeRoom == "2")
            {
                hargaRoom = 2_000_000;
                Console.WriteLine("{0}Price:\t\t{1}", deluxeRoom, hargaRoom);
            }
            else if (typeRoom == "3")
            {
                hargaRoom = 3_000_000;
                Console.WriteLine("{0}Price:\t\t{1}", suiteRoom, hargaRoom);
            }
            else if (typeRoom == "4")
            {
                hargaRoom = 4_000_000;
                Console.WriteLine("{0}Price:\t\t{1}", executiveRoom, hargaRoom);
            }
            else if (typeRoom == "5")
            {
                hargaRoom = 5_000_000;
                Console.WriteLine("{0}Price:\t\t{1}", businessRoom, hargaRoom);
            }
            else
            {
                failInput gagal = new failInput();
                gagal.failRoom();
            }
        }
    }
}

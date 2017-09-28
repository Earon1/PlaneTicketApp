using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlaneTicketApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Check In Aplication.\n\n");

            var instance = new flightNumClass();
            instance.inputFlightNum();      // calls input number class

            double flightNum = flightNumClass.flightNum;   
            string flightNumStrg = flightNum.ToString();    // convert flight num to string
            flightNumStrg = flightNumStrg + ".txt";         // add .txt to flight num

            fileControlClass.checkFile(flightNumStrg);      // calls file class

            Console.ReadKey();

            Passenger passenger = new Passenger();

            


        }
    }
}

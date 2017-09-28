using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicketApp
{
    class flightNumClass
    {
        public static double flightNum;     // variable of flight name
        
        // function for inputing flight number
        public void inputFlightNum()
        {
            
            int confFlightNum;
            string flightNumUserInput;
            bool flightNumResult;
            //double flightNum;
            
            Console.WriteLine("Please enter your flight number.\n");
            flightNumUserInput = Console.ReadLine();
            flightNumResult = double.TryParse(flightNumUserInput, out flightNum);       // trying to parse input to flight number

            if (flightNumResult == false)       // check is inputed number valid flight number
            {
                Console.WriteLine("Invalid flight number. Please try again.\n");
                inputFlightNum();
            }
            else
            {
            confirmFlightNum:
                Console.WriteLine("Confirm your flight number.\nFlight number: " + flightNum + "\nPress 1 for confirm, 2 for reentering flight number.\n");
                confFlightNum = int.Parse(Console.ReadLine());
                switch (confFlightNum)
                {
                    case 1:
                        break; // user confirmed flight num
                    case 2:     // user reentering fl num
                        inputFlightNum();   
                        break; 
                    default:    // invalid input
                        Console.WriteLine("Invalid input.\n");
                        goto confirmFlightNum;
                        
                }
            }

        
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicketApp
{
    class MainMenuClass
    {
        public static void MainMenu()
        {
            int mainMenuInput;
            string mainMenuUserInput;
            bool mainMenuResult;
            Console.WriteLine("------------------MAIN MENU-----------------\n\n");
            Console.WriteLine("Please type:\n -1 to check in\n -2 to view seating chart\n -3 to select your own seat\n -4 to exit");
            mainMenuUserInput = Console.ReadLine();
            mainMenuResult = int.TryParse(mainMenuUserInput, out mainMenuInput);
            if (mainMenuResult == false)
            {
                Console.WriteLine("Invalid input, try again.\n");
                MainMenu();
            }
            else
            {
                switch (mainMenuInput)
                {
                    case 1:
                        checkIn(); 
                        break;
                    case 2:
                        Console.WriteLine("see plane\n");
                        // see plane
                        break;
                    case 3:
                        Console.WriteLine("choose seat.\n");
                        // choose seat
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input.\n");
                        MainMenu();
                        break;
                }
            }//else
        }//main menu method

        public static void checkIn()
        {
            string name;
            string lastName;
            string classInput;
            int classInt;
            bool classResult;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Please input 1 for first class, 2 for economy class: ");
            classInput = Console.ReadLine();
            classResult = int.TryParse(classInput, out classInt);
            if (classResult == false)
            {
                Console.WriteLine("Invalid input, try again.\n");
                checkIn();
            }
            else
            {
                if (classInt == 1 || classInt == 2)
                {
                    fileControlClass.checkIsFull(name, lastName, classInt);
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.\n");
                    checkIn();
                }
                
            }
        }//check in

    }
}

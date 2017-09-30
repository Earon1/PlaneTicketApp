using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlaneTicketApp
{
    class fileControlClass
    {
        public static string fileName = flightNumClass.flightNum + ".txt";
        // function for checking is file already exist
        public static void checkFile(string Namefile)
        {
            if (File.Exists(Namefile))
            {
                Console.WriteLine("exist");
                //File.Open(fileName, FileMode.Open);
                readFile();
            }
            else
            {
                Console.WriteLine("dont exist");
                createFile(Namefile);
            }
            
        }

        // function for reading file
        static void readFile()
        {
            Console.WriteLine("Reading...");
        }

        // function for creating file
        static void createFile(string Namefile)
        {
            FileStream fs = File.Create(Namefile);
        }

        // method for writing in file.
        static void writeFile(string name, string lastName, int row, int seat)
        {
            
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.Write(name + " ");
                sw.Write(lastName + " ");
                sw.Write(row + " ");
                sw.WriteLine(seat);
            }
            
        }

        // method for chcking is seat class full.
        public static void checkIsFull(string name, string lastName, int seatClass)
        {
            Console.WriteLine("checking is it full...");

            StreamReader sr = new StreamReader(fileName);
            string[] words = sr.ReadToEnd().Split(' ');

            for (int row = 1; row < 3; row++)
            {
                for (int seat = 1; seat < 6; seat++)
                {
                   
                }
            }
            
        }



    }
}

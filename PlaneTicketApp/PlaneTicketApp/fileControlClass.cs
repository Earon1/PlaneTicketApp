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
        // function for checking is file already exist
        public static void checkFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                Console.WriteLine("exist");
                File.Open(fileName, FileMode.Open);
                readFile();
            }
            else
            {
                Console.WriteLine("dont exist");
                createFile(fileName);
            }
            
        }

        // function for reading file
        static void readFile()
        {
            Console.WriteLine("Reading...");
        }

        // function for creating file
        static void createFile(string fileName)
        {
            FileStream fs = File.Create(fileName);
        }



    }
}

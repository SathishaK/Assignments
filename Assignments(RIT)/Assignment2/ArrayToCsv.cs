using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class ArrayToCsv
    {
        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "Hi";
            files[0, 1] = "Hello";
            files[0, 2] = "asd";
            files[0, 3] = "cool";
            files[0, 4] = "resilience";

            files[1, 0] = "Sathish";
            files[1, 1] = "97";
            files[1, 2] = "9";
            files[1, 3] = "Hassan";
            files[1, 4] = "Bangalore";

            StreamWriter sw = File.CreateText("Text.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");

                }

                sw.Write("\n");

            }
            sw.Flush();
            sw.Close();
            Console.WriteLine("Array to csv file converstion Successfull");

        }
    }
}

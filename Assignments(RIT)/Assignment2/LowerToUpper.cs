using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigns
{
    
 
    class LowerToUpper
    {
        static void Main(string [] args)
        {
            
            string name = @"C:\Users\Sathisha K\source\repos\Assgn\Assgn\SampleData.csv";

            if (File.Exists(name))
            {
                StreamReader fileReader = File.OpenText(name);
                StreamWriter fileWriter = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileReader.ReadLine();
                    if (line != null)
                        fileWriter.WriteLine(line.ToUpper());
                }
                while (line != null);
                fileReader.Close();
                fileWriter.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}

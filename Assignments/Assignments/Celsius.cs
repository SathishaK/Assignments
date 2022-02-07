using System;

namespace day1
{
    class Celsius
    {
        static void Main()
        {
            Console.Write("Enter the Ammount of celsius degrees:");
            int celsius = int.Parse(Console.ReadLine());
            int Kelvin = 0, Fahreheit = 0;
            Kelvin = celsius + 273;
            Fahreheit = celsius * 18 / 10 + 32;
            Console.WriteLine("Kelvin={0}", Kelvin);
            Console.WriteLine("Fahreheit={0}", Fahreheit);
        }
    }
}

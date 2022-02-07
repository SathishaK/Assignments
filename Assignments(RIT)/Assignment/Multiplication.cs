using System;


namespace day1
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number:");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(a + "*" + i + "=" + i * a);
                i++;
            }
            Console.ReadLine();
        }
    }
}

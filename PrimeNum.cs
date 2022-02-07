
using System;

namespace Assignments
{
    class PrimeNum
    {
       static bool isPrime(int n)

        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
              
            }
            return true;
        }
        static void Main(string [] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (isPrime(n))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
               
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class SumOfPrime

    {
        static bool checkPrime(int numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return false;
            }
            for (int i = 2;i * i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int primeSum(int s, int k)
        {
            int sum = 0;
            for (int i = k; i >= s; i--)

            {
                bool isPrime = checkPrime(i);
                if (isPrime)
                { 
                 sum = sum + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int s = 10, k = 20;
            Console.Write("enter from value:");
            s = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter To value:");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sum of prime numbers");
            Console.Write(primeSum(s, k));
            Console.ReadLine();

        }
    }
}

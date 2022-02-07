using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class AverageNandP
    {
        public static void Main(string[] args)
        {
            int PSum = 0;
            int NSum = 0;
            int PCount = 0;
            int nCount = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the Numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    PCount += 1;
                    PSum += n;
                }
                else
                {
                    nCount += 1;
                    NSum += n;

                }
            }

            Console.WriteLine($"The Average of Postive numbers: {PSum / PCount}" +
                              $"\n The Average of Negative Numbers :{NSum / nCount}");

        }

    }
}

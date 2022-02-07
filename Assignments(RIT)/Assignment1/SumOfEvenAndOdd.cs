using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;namespace Assigns{
        class SumOfEvenAndOdd
        {
            static void Main(string [] args)
            {
                sumofevenandodd();
            }
            static void sumofevenandodd()
            {
                int evenSum = 0;
                int oddSum = 0;
                int[] sum = new int[10];
                for (int i = 0; i < sum.Length; i++)
                {
                    Console.WriteLine($"Enter the number{i + 1}:");
                    sum[i] = int.Parse(Console.ReadLine());
                }
                foreach (int total in sum)
                {
                    if (total % 2 == 0)
                    {
                        evenSum = total + evenSum;
                    }
                    else
                    {
                        oddSum = total + oddSum;
                    }
                }
                Console.WriteLine($"Even Sum is :{evenSum}");
                Console.WriteLine($"Odd Sum is: {oddSum}");
            }
        }
   }
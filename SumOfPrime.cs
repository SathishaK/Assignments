﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class SumOfPrime

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
            s = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
}
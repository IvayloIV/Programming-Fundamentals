﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintResult(n);
        }

        private static void PrintResult(int n)
        {
            if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else
            {
                Console.WriteLine($"The number 0 is zero.");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var num = i;
                var sum = 0;
                while (num != 0)
                {
                    var lastNum = num % 10;
                    sum += lastNum;
                    num /= 10;
                }
                if (sum == 7 || sum == 5 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}

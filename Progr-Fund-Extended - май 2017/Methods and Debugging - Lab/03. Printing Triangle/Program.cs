using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintNums(1, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintNums(1, i);
            }
        }

        private static void PrintNums(int v, int t)
        {
            for (int i = v; i <= t; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}

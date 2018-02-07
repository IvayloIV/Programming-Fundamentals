using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var digit = FindNtxDigit(num, n);
            Console.WriteLine(digit);
        }

        private static long FindNtxDigit(long num, int n)
        {
            var count = 0;
            while (true)
            {
                count++;
                var lastN = num % 10;
                if (count == n)
                {
                    return lastN;
                }
                num /= 10;
            }
        }
    }
}

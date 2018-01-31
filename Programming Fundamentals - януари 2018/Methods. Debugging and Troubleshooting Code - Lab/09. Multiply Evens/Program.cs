using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Multiply_Evens
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }

        private static int GetMultipleOfEvenAndOdds(int n)
        {
            n = Math.Abs(n);
            var sumEvens = GetSumOddsAndEven(n , 0);
            var sumOdds = GetSumOddsAndEven(n, 1);
            return sumEvens * sumOdds;
        }

        private static int GetSumOddsAndEven(int n, int k)
        {
            var sum = 0;

            while (n > 0)
            {
                var lastNum = n % 10;
                if (lastNum % 2 == k)
                {
                    sum += lastNum;
                }
                n /= 10;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintFactorial(n);
        }

        private static void PrintFactorial(int n)
        {
            BigInteger sum = 1;
            for (int i = 2; i <= n; i++)
            {
                sum *= i;
            }
            CalculateZeros(sum);
        }

        private static void CalculateZeros(BigInteger sum)
        {
            var count = 0;
            while (sum > 0)
            {
                var lastDigit = sum % 10;
                if (lastDigit == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                sum /= 10;
            }
            Console.WriteLine(count);
        }
    }
}

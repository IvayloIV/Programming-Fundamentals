using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstDigit = 1;
            var secondDigit = 1;
            CalculateResult(n, firstDigit, secondDigit);                     
        }

        private static void CalculateResult(int n, int firstDigit, int secondDigit)
        {
            if (n == 0 || n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            for (int i = 2; i <= n; i++)
            {
                var minNum = firstDigit;
                firstDigit = secondDigit;
                secondDigit = minNum + secondDigit;
            }
            PrintResult(secondDigit);
        }

        private static void PrintResult(int secondDigit)
        {
            Console.WriteLine(secondDigit);
        }
    }
}

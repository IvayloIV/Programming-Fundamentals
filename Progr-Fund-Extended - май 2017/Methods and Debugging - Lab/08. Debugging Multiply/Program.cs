using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Debugging_Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));
            var sumEven = CalculateEvenSum(n);
            var sumOdd = CalculateOddSum(n);
            var result = CalculateResult(sumEven, sumOdd);
            Console.WriteLine(result);
        }

        private static object CalculateResult(int sumEven, int sumOdd)
        {
            return sumOdd * sumEven;
        }

        private static int CalculateOddSum(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                var lastNum = n % 10;
                if (lastNum % 2 == 1)
                {
                    sum += lastNum;
                }
                n /= 10;
            }
            return sum;
        }

        private static int CalculateEvenSum(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                var lastNum = n % 10;
                if (lastNum % 2 == 0)
                {
                    sum += lastNum;
                }
                n /= 10;
            }
            return sum;
        }
    }
}

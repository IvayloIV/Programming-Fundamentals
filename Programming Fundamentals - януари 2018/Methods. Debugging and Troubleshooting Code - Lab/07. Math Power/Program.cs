using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var result = CalculateResult(num, n);
            Console.WriteLine(result);
        }

        private static double CalculateResult(double num, int n)
        {
            var sum = 1d;
            for (int i = 0; i < n; i++)
            {
                sum *= num;
            }
            return sum;
        }
    }
}

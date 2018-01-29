using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var pow = int.Parse(Console.ReadLine());
            double result = CalculatePow(num, pow);
            Console.WriteLine(result);
        }

        private static double CalculatePow(double num, int pow)
        {
            var currentNum = 1d;
            for (int i = 0; i < pow; i++)
            {
                currentNum *= num;
            }
            return currentNum;
        }
    }
}

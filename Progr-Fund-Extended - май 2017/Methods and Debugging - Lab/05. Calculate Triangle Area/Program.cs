using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var result = CalculateArea(num1, num2);
            Console.WriteLine(result);
        }

        private static double CalculateArea(double num1, double num2)
        {
            return (num1 * num2) / 2;
        }
    }
}

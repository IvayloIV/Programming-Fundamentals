using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            PrintCloosestPoint(x1, y1, x2, y2);
        }

        private static void PrintCloosestPoint(double x1, double y1, double x2, double y2)
        {
            var firstPoint = Math.Sqrt(x1 * x1 + y1 * y1);
            var secondPoint = Math.Sqrt(x2 * x2 + y2 * y2);

            if (firstPoint < secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}

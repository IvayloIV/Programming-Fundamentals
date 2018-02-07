using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            PrintResult(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void PrintResult(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (LineLenght(x1, y1, x2, y2) >= LineLenght(x3, y3, x4, y4))
            {
                PrintClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPoint(x3, y3, x4, y4);
            }
        }

        private static void PrintClosestPoint(double x3, double y3, double x4, double y4)
        {
            if (DistanceToCenter(x3, y3) > DistanceToCenter(x4, y4))
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
            else
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
        }

        private static double DistanceToCenter(double x3, double y3)
        {
            return Math.Sqrt(x3 * x3 + y3 * y3);
        }

        private static double LineLenght(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }
}

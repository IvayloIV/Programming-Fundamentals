using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "triangle")
            {
                PrintTriangleArea();
            }
            else if (type == "square")
            {
                PrintSquareArea();
            }
            else if (type == "rectangle")
            {
                PrintRectangleArea();
            }
            else if (type == "circle")
            {
                PrintCircleArea();
            }
        }

        private static void PrintCircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            PrintResult(area);
        }

        private static void PrintRectangleArea()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;
            PrintResult(area);
        }

        private static void PrintSquareArea()
        {
            var side = double.Parse(Console.ReadLine());
            var area = side * side;
            PrintResult(area);
        }

        private static void PrintTriangleArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = side * height / 2;
            PrintResult(area);
        }

        private static void PrintResult(double area)
        {
            Console.WriteLine($"{area:f2}");
        }
    }
}

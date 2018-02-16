using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
            Point firstPoint = CreatePoint();
            Point secondPoint = CreatePoint();
            double diff = DifferentByPoints(firstPoint, secondPoint);
            Console.WriteLine($"{diff:f3}");
        }

        private static double DifferentByPoints(Point firstPoint, Point secondPoint)
        {
            var x = firstPoint.X - secondPoint.X;
            var xPow = x * x;
            var y = firstPoint.Y - secondPoint.Y;
            var yPow = y * y;
            return Math.Sqrt(xPow + yPow);
        }

        private static Point CreatePoint()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return new Point
            {
                X = input[0],
                Y = input[1]
            };
        }
    }
}

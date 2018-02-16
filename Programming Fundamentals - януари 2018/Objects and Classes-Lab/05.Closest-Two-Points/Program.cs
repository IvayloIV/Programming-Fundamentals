using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public string GetResult()
            {
                return $"({X}, {Y})";
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var rectArr = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                rectArr.Add(CreatePoint());
            }
            var minDiff = double.MaxValue;
            var firstPointMin = new Point();
            var secondPointMin = new Point();
            for (int i = 0; i < rectArr.Count(); i++)
            {
                for (int q = i + 1; q < rectArr.Count(); q++)
                {
                    var diff = DifferentByPoints(rectArr[i], rectArr[q]);
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        firstPointMin = rectArr[i];
                        secondPointMin = rectArr[q];
                    }
                }
            }
            Console.WriteLine($"{minDiff:f3}");
            Console.WriteLine(firstPointMin.GetResult());
            Console.WriteLine(secondPointMin.GetResult());
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

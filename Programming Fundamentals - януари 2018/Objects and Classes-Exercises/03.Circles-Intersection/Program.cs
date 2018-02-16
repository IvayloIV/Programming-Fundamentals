using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        class Points
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Radius { get; set; }
        }
        static void Main(string[] args)
        {
            var firstPoint = CreatePoint();
            var secondPoint = CreatePoint();
            bool isInside = Intersect(firstPoint, secondPoint);
            Console.WriteLine(isInside ? "Yes" : "No");
        }

        private static bool Intersect(Points firstPoint, Points secondPoint)
        {
            var d = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            var r = firstPoint.Radius + secondPoint.Radius;
            if (r >= d)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static Points CreatePoint()
        {
            var currentPointTokens = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            return new Points {
                X = currentPointTokens[0],
                Y = currentPointTokens[1],
                Radius = currentPointTokens[2]
            };
        }
    }
}

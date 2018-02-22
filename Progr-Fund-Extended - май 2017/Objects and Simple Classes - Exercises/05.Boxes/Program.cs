using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Program
    {
        class Box
        {
            public Points UpperLeft { get; set; }
            public Points UpperRight { get; set; }
            public Points BottomLeft { get; set; }
            public Points BottomRight { get; set; }
            public Box(Points upperLeft, Points upperRight, Points bottomLeft, Points bottomRight)
            {
                UpperLeft = upperLeft;
                UpperRight = upperRight;
                BottomLeft = bottomLeft;
                BottomRight = bottomRight;
            }
            public double Width
            {
                get
                {
                    return Points.CalcDistance(UpperLeft, UpperRight);
                }
            }
            public double Height
            {
                get
                {
                    return Points.CalcDistance(UpperLeft, BottomLeft);
                }
            }
            public static int CalculatePerimeter(int width, int height)
            {
                return 2 * (width + height);
            }
            public static int CalculateArea(int width, int height)
            {
                return width * height;
            }
        }
        class Points
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Points(int x, int y)
            {
                X = x;
                Y = y;
            }
            public static double CalcDistance(Points first, Points second)
            {
                var x = first.X - second.X;
                var y = first.Y - second.Y;
                return Math.Sqrt((x * x) + (y * y));
            }
        }
        static void Main(string[] args)
        {
            var book = new List<Box>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                book.Add(new Box(CreatePoints(inputTokens[0]), CreatePoints(inputTokens[1]), CreatePoints(inputTokens[2]), CreatePoints(inputTokens[3])));
            }
            foreach (var item in book)
            {
                Console.WriteLine($"Box: {item.Width}, {item.Height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter((int)item.Width, (int)item.Height)}");
                Console.WriteLine($"Area: {Box.CalculateArea((int)item.Width, (int)item.Height)}");
            }
        }
        private static Points CreatePoints(string v)
        {
            var vTokens = v.Split(':').ToArray();
            return new Points(int.Parse(vTokens[0]), int.Parse(vTokens[1]));
        }
    }
}

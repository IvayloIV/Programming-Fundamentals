using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        class Sides
        {
            public double Left { get; set; }
            public double Top { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }
            public double Right
            {
                get { return Left + Width;}
            }
            public double Bottom
            {
                get { return Top + Height; }
            }
            public bool IsInside(Sides other)
            {
                return Left >= other.Left && Right <= other.Right && Top <= other.Top && Bottom <= other.Bottom;
            }
        }
        static void Main(string[] args)
        {
            var firstRect = GetRect();
            var secondRect = GetRect();
            Console.WriteLine(firstRect.IsInside(secondRect) ? "Inside" : "Not inside");
        }

        private static Sides GetRect()
        {
            var arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            return new Sides
            {
                Left = arr[0],
                Top = arr[1],
                Width = arr[2],
                Height = arr[3]
            };
        }
    }
}

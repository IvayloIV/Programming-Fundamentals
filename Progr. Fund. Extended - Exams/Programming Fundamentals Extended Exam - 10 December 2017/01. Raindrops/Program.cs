using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var density = double.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                var raindropsCount = input[0];
                var squareMeters = input[1];
                sum += (raindropsCount / squareMeters);
            }

            if (density != 0)
            {
                sum /= density;
            }
            Console.WriteLine($"{sum:f3}");
        }
    }
}

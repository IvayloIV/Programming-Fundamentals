using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var bodyLength = decimal.Parse(Console.ReadLine());
                var bodyWidth = decimal.Parse(Console.ReadLine());
                var lengthOneWing = decimal.Parse(Console.ReadLine());

                decimal totalYears = bodyLength * bodyLength * (bodyWidth + 2 * lengthOneWing);
                Console.WriteLine($"{totalYears}");
            }
        }
    }
}

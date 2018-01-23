using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthSm = decimal.Parse(Console.ReadLine()) * 100;
            var width = decimal.Parse(Console.ReadLine());
            if (width == 0) {
                Console.WriteLine($"{(lengthSm * width):f2}");
                return;
            }

            var remainder = lengthSm % width;

            if (remainder == 0)
            {
                Console.WriteLine($"{(lengthSm * width):f2}");
            }
            else
            {
                Console.WriteLine($"{((lengthSm / width) * 100):f2}%");
            }
        }
    }
}

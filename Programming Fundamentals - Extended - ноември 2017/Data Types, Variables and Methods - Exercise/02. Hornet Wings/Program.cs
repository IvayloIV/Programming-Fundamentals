using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());

            var distance = (n / 1000) * m;
            Console.WriteLine($"{distance:f2} m.");

            var hornestFlaps = n / 100;
            var rest = Math.Floor(n / p) * 5;
            var sum = hornestFlaps + rest;
            Console.WriteLine($"{sum} s.");
        }
    }
}

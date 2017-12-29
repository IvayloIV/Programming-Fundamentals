using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var p = double.Parse(Console.ReadLine());

            var distance = (n / 1000D) * m;
            Console.WriteLine($"{distance:f2} m.");
            var hornestFlaps = n / 100;
            var hornestReset = ((int)n / (int)p) * 5;
            var all = hornestFlaps + hornestReset;
            Console.WriteLine($"{all:f0} s.");
        }
    }
}

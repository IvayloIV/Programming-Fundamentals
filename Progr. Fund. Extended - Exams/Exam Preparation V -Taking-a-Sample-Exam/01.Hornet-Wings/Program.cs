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
            var n = long.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var p = long.Parse(Console.ReadLine());
            var distanceInMetres = (n / 1000d) * m;
            Console.WriteLine($"{distanceInMetres:f2} m.");
            var hornetFlaps = n / 100d;
            var restHornetTime = (n / p) * 5;
            Console.WriteLine($"{restHornetTime + hornetFlaps} s.");
        }
    }
}

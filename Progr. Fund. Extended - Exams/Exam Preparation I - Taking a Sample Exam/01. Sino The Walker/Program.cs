using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = Console.ReadLine();
            var steps = long.Parse(Console.ReadLine());
            var stepSec = long.Parse(Console.ReadLine());

            var hourTokens = hour.Split(':').Select(long.Parse).ToArray();
            var allSec = (steps * stepSec) + ((hourTokens[0] * 3600) + (hourTokens[1] * 60) + hourTokens[2]);

            var hours = (allSec / 3600) % 24;
            var minutes = (allSec % 3600) / 60;
            var secounds = allSec % 60;
            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{secounds:d2}");
        }
    }
}

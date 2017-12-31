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
            var time = Console.ReadLine().Split(new[] { ":"},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var steps = long.Parse(Console.ReadLine());
            var timeForSteps = long.Parse(Console.ReadLine());

            var allTimeSteps = steps * timeForSteps;
            var timeSecounds = (time[0] * 3600) + (time[1] * 60) + time[2];
            var allSecounds = timeSecounds + allTimeSteps;

            PrintResult(allSecounds);
        }

        private static void PrintResult(long allSecounds)
        {
            var hours = (allSecounds / 3600) % 24;
            var minutes = (allSecounds % 3600) / 60;
            var secounds = allSecounds % 60;
            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{secounds:d2}");
        }
    }
}

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
            var time = Console.ReadLine();
            var steps = long.Parse(Console.ReadLine());
            var timeForSteps = long.Parse(Console.ReadLine());

            var allTime = time.Split(new[] { ":" },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var hours = allTime[0];
            var minutes = allTime[1];
            var secounds = allTime[2];

            var allInSecounds = (long)hours * 3600 + (long)minutes * 60 + secounds;
            allInSecounds += (steps * timeForSteps);
            var currentHour = (allInSecounds / 3600) % 24;
            var currentMinutes = (allInSecounds % 3600) / 60;
            var currendSec = allInSecounds % 60;
            Console.WriteLine($"Time Arrival: {currentHour:d2}:{currentMinutes:d2}:{currendSec:d2}");
        }
    }
}

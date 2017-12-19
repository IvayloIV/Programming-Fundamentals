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
            var hour = Console.ReadLine().Split(new[] { ":" },StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long numberSteps = long.Parse(Console.ReadLine());
            long stepTime = long.Parse(Console.ReadLine());

            var allSecounds = hour[0] * 3600 + hour[1] * 60 + hour[2];
            allSecounds += (numberSteps * stepTime);

            var hours = (allSecounds / 3600) % 24;
            var minutes = (allSecounds % 3600) / 60;
            allSecounds = allSecounds % 60;
            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{allSecounds:d2}");
        }
    }
}

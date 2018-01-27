using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var maratonsDays = int.Parse(Console.ReadLine());
            var runnerCount = long.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            var lapLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            if (trackCapacity * maratonsDays < runnerCount)
            {
                runnerCount = trackCapacity * maratonsDays;
            }

            var totalKm = (runnerCount * laps * lapLength) / 1000D;
            Console.WriteLine($"Money raised: {(totalKm * moneyPerKm):f2}");
        }
    }
}

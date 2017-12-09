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
            var allDays = int.Parse(Console.ReadLine());
            long participateRunners = int.Parse(Console.ReadLine());
            var laps = int.Parse(Console.ReadLine());
            var lenghtOfTrack = int.Parse(Console.ReadLine());
            var capasityTrack = int.Parse(Console.ReadLine());
            var donation = double.Parse(Console.ReadLine());

            long maxRunners = capasityTrack * allDays;

            if (participateRunners > maxRunners)
            {
                participateRunners = maxRunners;
            }

            var totalMtr = participateRunners * laps * lenghtOfTrack;
            var totalKm = (double)totalMtr / 1000;
            var moneyRaised = totalKm * donation;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}

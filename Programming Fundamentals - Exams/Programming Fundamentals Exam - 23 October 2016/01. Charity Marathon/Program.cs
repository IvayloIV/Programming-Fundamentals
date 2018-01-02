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
            var marathonDays = long.Parse(Console.ReadLine());
            var countParticipant = long.Parse(Console.ReadLine());
            var laps = long.Parse(Console.ReadLine());
            var trackLenght = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            MakeCalculations(marathonDays, countParticipant, laps, trackLenght, trackCapacity, moneyPerKm);
        }

        private static void MakeCalculations(long marathonDays, long countParticipant, long laps, long trackLenght, long trackCapacity, double moneyPerKm)
        {
            if (marathonDays * trackCapacity < countParticipant)
            {
                countParticipant = marathonDays * trackCapacity;
            }

            var totalMs = countParticipant * laps * trackLenght;
            var totalKm = totalMs / 1000D;
            var moneyRaised = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}

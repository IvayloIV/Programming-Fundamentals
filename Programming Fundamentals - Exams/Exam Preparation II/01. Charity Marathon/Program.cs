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
            var daysMarathon = int.Parse(Console.ReadLine());
            var countParticipant = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var lenghtTrack = int.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var moneyDoneited = double.Parse(Console.ReadLine());

            if (daysMarathon * capacityOfTrack < countParticipant)
            {
                countParticipant = daysMarathon * capacityOfTrack;
            }

            long totalM = (long)countParticipant * averageLaps * lenghtTrack;
            var totalKm = totalM / 1000D;
            var allRaisedMoney = totalKm * moneyDoneited;
            Console.WriteLine($"Money raised: {allRaisedMoney:f2}");
        }
    }
}

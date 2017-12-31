using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var zones = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var indexs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            MakeCalculations(participants, zones, indexs);    
        }

        private static void MakeCalculations(string[] participants, double[] zones, int[] indexs)
        {
            foreach (var item in participants)
            {
                var firstLetter = (double)char.Parse(new string(item.Take(1).ToArray()));

                var bad = false;
                for (int i = 0; i < zones.Length; i++)
                {
                    if (indexs.Contains(i))
                    {
                        firstLetter += zones[i];
                    }
                    else
                    {
                        firstLetter -= zones[i];
                    }
                    if (firstLetter <= 0)
                    {
                        bad = true;
                        Console.WriteLine($"{item} - reached {i}");
                        break;
                    }
                }
                if (!bad)
                {
                    Console.WriteLine($"{item} - fuel left {firstLetter:f2}");
                }
            }
        }
    }
}

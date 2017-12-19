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
            var names = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var allZones = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var chekPoints = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var name in names)
            {
                var firstLetter = (double)char.Parse(new string(name.Take(1).ToArray()));
                var isOkey = true;
                for (int i = 0; i < allZones.Length; i++)
                {
                    if (chekPoints.Contains(i))
                    {
                        firstLetter += allZones[i];
                    }
                    else
                    {
                        firstLetter -= allZones[i];
                    }

                    if (firstLetter <= 0)
                    {
                        Console.WriteLine($"{name} - reached {i}");
                        isOkey = false;
                        break;
                    }                
                }
                if (isOkey)
                {
                    Console.WriteLine($"{name} - fuel left {firstLetter:f2}");
                }
            }
        }
    }
}

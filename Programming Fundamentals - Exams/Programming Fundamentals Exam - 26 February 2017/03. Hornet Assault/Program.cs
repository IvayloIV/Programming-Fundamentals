using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornest = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            var killsHornest = 0;
            var attackHornest = hornest.Skip(killsHornest).ToList().Sum();
            for (int i = 0; i < beehives.Count(); i++)
            {
                if (attackHornest == 0)
                {
                    break;
                }

                beehives[i] -= attackHornest;

                if (beehives[i] >= 0)
                {
                    attackHornest -= hornest[killsHornest];
                    killsHornest++;
                }
                else
                {
                    beehives[i] = 0;
                }
            }
            PrinResult(beehives, hornest, killsHornest);
        }

        private static void PrinResult(List<long> beehives, List<long> hornest, int killsHornest)
        {
            if (beehives.Any(a => a != 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(a => a != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornest.Skip(killsHornest).ToArray()));
            }
        }
    }
}

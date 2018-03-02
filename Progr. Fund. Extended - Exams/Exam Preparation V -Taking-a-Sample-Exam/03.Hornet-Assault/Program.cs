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
            var beehives = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            var hornets = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            decimal totamSumPower = hornets.Sum();
            var count = 0;
            for (int i = 0; i < beehives.Count(); i++)
            {
                beehives[i] -= totamSumPower;
                if (beehives[i] >= 0)
                {
                    totamSumPower -= hornets[count];
                    count++;
                    if (totamSumPower == 0)
                    {
                        break;
                    }
                }
            }
            if (beehives.Any(a => a > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(a => a > 0).ToList()));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Skip(count).ToList()));
            }
        }
    }
}

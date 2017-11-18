using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornest = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long sum = hornest.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {           
                if (beehives[i] >= sum)
                {
                    beehives[i] -= sum;
                    hornest.RemoveAt(0);
                }               
                else
                {
                    beehives[i] = 0;
                }
                sum = hornest.Sum();
                if (sum == 0)
                {
                    break;
                }
            }

            if (beehives.Any(a => a != 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(a => a != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornest));
            }
        }
    }
}

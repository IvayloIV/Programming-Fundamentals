using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal oneLightYear = 9450000000000;
            decimal nearestStar = 4.22M * oneLightYear;
            decimal centerGalaxy = 26000 * oneLightYear;
            decimal milkyWay = 100000 * oneLightYear;
            decimal edgeUniv = 46500000000 * oneLightYear;
            Console.WriteLine(nearestStar.ToString("e2"));
            Console.WriteLine(centerGalaxy.ToString("e2"));
            Console.WriteLine(milkyWay.ToString("e2"));
            Console.WriteLine(edgeUniv.ToString("e2"));
        }
    }
}

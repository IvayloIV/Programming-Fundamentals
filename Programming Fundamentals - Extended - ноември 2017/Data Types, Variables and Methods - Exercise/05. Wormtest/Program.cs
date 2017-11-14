using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lenght = decimal.Parse(Console.ReadLine()) * 100;
            decimal width = decimal.Parse(Console.ReadLine());

            if (width == 0)
            {
                Console.WriteLine($"{(lenght * width):f2}");
            }
            else if (lenght % width == 0)
            {
                Console.WriteLine($"{(lenght * width):f2}");
            }
            else
            {
                Console.WriteLine($"{((lenght / width) * 100):f2}%");
            }
        }
    }
}

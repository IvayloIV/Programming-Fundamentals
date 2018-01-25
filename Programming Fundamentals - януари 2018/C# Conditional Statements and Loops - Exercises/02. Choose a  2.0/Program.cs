using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a__2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var personWork = Console.ReadLine();
            var quant = int.Parse(Console.ReadLine());

            if (personWork == "Athlete")
            {
                Console.WriteLine($"The Athlete has to pay {(quant * 0.7):f2}.");
            }
            else if (personWork == "Businessman") {
                Console.WriteLine($"The Businessman has to pay {(quant):f2}.");
            }
            else if (personWork == "Businesswoman")
            {
                Console.WriteLine($"The Businesswoman has to pay {(quant):f2}.");
            }
            else if (personWork == "SoftUni Student")
            {
                Console.WriteLine($"The SoftUni Student has to pay {(quant * 1.7):f2}.");
            }
            else
            {
                Console.WriteLine($"The {personWork} has to pay {(quant * 1.2):f2}.");
            }
        }
    }
}

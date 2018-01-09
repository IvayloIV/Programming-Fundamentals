using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal allSum = 0;
            for (int i = 0; i < n; i++)
            {
                var sum = MakeCalculations();
                
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                allSum += sum;
            }
            Console.WriteLine($"Total: ${allSum:f2}");
        }

        private static decimal MakeCalculations()
        {
            var price = decimal.Parse(Console.ReadLine());
            var date = Console.ReadLine().Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var capsules = decimal.Parse(Console.ReadLine());

            var days = DateTime.DaysInMonth(date[2], date[1]);
            return days * capsules * price;
        }
    }
}

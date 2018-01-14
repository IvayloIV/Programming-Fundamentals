using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Softuni_Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal totals = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                decimal days = DateTime.DaysInMonth(date[2], date[1]);
                decimal price = days * pricePerCapsule * capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totals += price;
            }
            Console.WriteLine($"Total: ${totals:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sum = 0M;
            for (int i = 0; i < n; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var dataTokens = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                var countCapsule = int.Parse(Console.ReadLine());

                var days = DateTime.DaysInMonth(dataTokens[2], dataTokens[1]);
                var orderPrice = (decimal)days * countCapsule * price;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                sum += orderPrice;
            }
            Console.WriteLine($"Total: ${sum:f2}");
        }
    }
}

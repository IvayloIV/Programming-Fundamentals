using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var sum = 0D;
            for (int i = 0; i < n; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1) {
                    itemName = $"{itemName}s";
                }

                var currentSum = itemPrice * itemCount;
                sum += currentSum;
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }
            Console.WriteLine($"Subtotal: ${sum:f2}");
            if (budjet >= sum)
            {
                Console.WriteLine($"Money left: ${(budjet - sum):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(sum - budjet):f2} more.");
            }
        }
    }
}

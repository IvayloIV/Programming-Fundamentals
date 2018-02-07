using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var quantity = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var nameProduct = inputTokens[0];
                var quantityNeeded = long.Parse(inputTokens[1]);
                var productIndex = Array.IndexOf(products, nameProduct);
                if (productIndex > quantity.Length - 1)
                {
                    PrintToMoreQuantity(nameProduct);
                    continue;
                }
                else if (quantity[productIndex] - quantityNeeded < 0)
                {
                    PrintToMoreQuantity(nameProduct);
                    continue;
                }
                else
                {
                    Console.WriteLine($"{nameProduct} x {quantityNeeded} costs {(price[productIndex] * quantityNeeded):f2}");
                    quantity[productIndex] -= quantityNeeded;
                }
            }
        }

        private static void PrintToMoreQuantity(string input)
        {
            Console.WriteLine($"We do not have enough {input}");
        }
    }
}

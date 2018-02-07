using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var quantity = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                var productIndex = Array.IndexOf(products, input);
                Console.WriteLine($"{input} costs: {price[productIndex]}; Available quantity: {quantity[productIndex]}");
            }
        }
    }
}

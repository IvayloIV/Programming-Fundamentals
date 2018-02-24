using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var book = new Dictionary<string, decimal>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var product = inputTokens[0];
                var price = decimal.Parse(inputTokens[1]);
                if (!book.ContainsKey(product))
                {
                    book[product] = decimal.MaxValue;
                }
                if (book[product] > price)
                {
                    book[product] = price;
                }
            }
            if (book.Values.Sum() > money)
            {
                Console.WriteLine($"Need more money... Just buy banichka");
            }
            else
            {
                foreach (var item in book.OrderByDescending(a => a.Value).ThenBy(a => a.Key.Length))
                {
                    Console.WriteLine($"{item.Key} costs {$"{item.Value:f2}"}");
                }
            }
        }
    }
}

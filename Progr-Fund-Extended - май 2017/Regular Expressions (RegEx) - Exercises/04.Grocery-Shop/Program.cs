using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, double>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "bill")
                {
                    break;
                }
                Match finding = Regex.Match(input, @"^(?<product>[A-Z][a-z]+):(?<price>[0-9]+\.[0-9]{2})$");
                if (!finding.Success) continue;
                var product = finding.Groups["product"].Value;
                var price = double.Parse(finding.Groups["price"].Value);
                book[product] = price;
            }
            foreach (var item in book.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{item.Key} costs {$"{item.Value:f2}"}");
            }
        }
    }
}

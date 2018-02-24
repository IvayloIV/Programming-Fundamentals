using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<double>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "chop chop") break;
                var inputTokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!book.ContainsKey(inputTokens[0]))
                {
                    book[inputTokens[0]] = new List<double>();
                }
                book[inputTokens[0]].Add(int.Parse(inputTokens[1]));
            }
            var typeTree = Console.ReadLine();
            var minLength = int.Parse(Console.ReadLine());
            var pricePerMeter = Math.Round(book.SelectMany(a => a.Value).Sum() / book.SelectMany(a => a.Value).Count(), 2);
            var usedLogsPrice = Math.Round(book.SelectMany(a => a.Value.Where(b => a.Key == typeTree && b >= minLength)).Sum() * pricePerMeter, 2);
            var unsedLogs = Math.Round(book.SelectMany(a => a.Value.Where(b => a.Key != typeTree || b < minLength)).Sum() * pricePerMeter * 0.25, 2);
            var allSum = usedLogsPrice + unsedLogs;
            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unsedLogs:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${allSum:f2}");
        }
    }
}

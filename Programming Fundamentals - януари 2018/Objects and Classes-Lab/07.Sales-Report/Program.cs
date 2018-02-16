using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        class Sales
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<Sales>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(' ').ToArray();
                if (!book.ContainsKey(inputTokens[0]))
                {
                    book[inputTokens[0]] = new List<Sales>();
                }
                book[inputTokens[0]].Add(CreateSales(inputTokens));
            }
            foreach (var item in book.OrderBy(a => a.Key))
            {
                var sum = 0D;
                foreach (var item2 in item.Value)
                {
                    sum += item2.Price * item2.Quantity;
                }
                Console.WriteLine($"{item.Key} -> {(sum):f2}");
            }
        }

        private static Sales CreateSales(string[] inputTokens)
        {
            return new Sales
            {
                Town = inputTokens[0],
                Product = inputTokens[1],
                Price = double.Parse(inputTokens[2]),
                Quantity = double.Parse(inputTokens[3])
            };
        }
    }
}

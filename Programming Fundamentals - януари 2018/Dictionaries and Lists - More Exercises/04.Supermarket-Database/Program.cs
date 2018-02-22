using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        class Sums
        {
            public double Price { get; set; }
            public int Quantity { get; set; }
            public Sums()
            {
                Price = 0.0;
                Quantity = 0;
            }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Sums>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stocked")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                if (!book.ContainsKey(inputTokens[0]))
                {
                    book[inputTokens[0]] = new Sums();
                }
                book[inputTokens[0]].Price = double.Parse(inputTokens[1]);
                book[inputTokens[0]].Quantity += int.Parse(inputTokens[2]);
            }
            var sum = 0d;
            foreach (var item in book)
            {
                var currentSum = item.Value.Price * item.Value.Quantity;
                Console.WriteLine($"{item.Key}: ${item.Value.Price:f2} * {item.Value.Quantity} = ${currentSum:f2}");
                sum += currentSum;
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${sum:f2}");
        }
    }
}

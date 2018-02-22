using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "shopping time")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                if (!book.ContainsKey(inputTokens[1]))
                {
                    book[inputTokens[1]] = 0;
                }
                book[inputTokens[1]] += int.Parse(inputTokens[2]);
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exam time")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                var product = inputTokens[1];
                var quantity = int.Parse(inputTokens[2]);
                if (!book.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else if (book[product] == 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else
                {
                    book[product] -= quantity;
                    if (book[product] < 0) book[product] = 0;
                }
            }
            foreach (var item in book.Where(a => a.Value != 0))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

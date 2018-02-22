using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Aggregate")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                var town = inputTokens[0];
                var shell = int.Parse(inputTokens[1]);
                if (!book.ContainsKey(town))
                {
                    book[town] = new List<int>();
                }
                if (book[town].All(a => a != shell))
                {
                    book[town].Add(shell);
                }
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)} ({Math.Ceiling(item.Value.Sum() - item.Value.Average())})");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                var name = inputTokens[0];
                var model = inputTokens[1];
                var timeToStay = int.Parse(inputTokens[2]);
                if (!book.ContainsKey(name))
                {
                    book[name] = new Dictionary<string, int>();
                }
                if (!book[name].ContainsKey(model))
                {
                    book[name][model] = timeToStay;
                }
            }
            foreach (var item in book.OrderByDescending(a => a.Value.Count()).ThenBy(a => a.Key.Length))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"***{item2.Key}");
                }
                Console.WriteLine($"Total stay: {item.Value.Values.Sum()} nights");
            }
        }
    }
}

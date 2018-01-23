using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var wormName = inputTokens[0];
                var teamName = inputTokens[1];
                var wormScore = long.Parse(inputTokens[2]);

                if (!book.All(a => a.Value.All(b => b.Key != wormName))) {
                    continue;
                }
                if (!book.ContainsKey(teamName))
                {
                    book[teamName] = new Dictionary<string, long>();
                }

                if (!book[teamName].ContainsKey(wormName))
                {
                    book[teamName][wormName] = wormScore;
                }
            }
            PrintResult(book);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> book)
        {
            var count = 1;
            foreach (var item in book.OrderByDescending(a => a.Value.Values.Sum())
                .ThenByDescending(a => a.Value.Sum(p => p.Value) / a.Value.Count()))
            {
                Console.WriteLine($"{count}. Team: {item.Key} - {item.Value.Values.Sum()}");
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"###{item2.Key} : {item2.Value}");
                }
                count++;
            }
        }
    }
}

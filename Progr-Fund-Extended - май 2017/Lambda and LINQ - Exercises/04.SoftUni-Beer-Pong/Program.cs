using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Beer_Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop the game") break;
                var inputTokens = input.Split('|').ToArray();
                var team = inputTokens[1];
                var name = inputTokens[0];
                var points = long.Parse(inputTokens[2]);
                if (!book.ContainsKey(team))
                {
                    book[team] = new Dictionary<string, long>();
                }
                if (book[team].Count() < 3)
                {
                    book[team][name] = points;
                }
            }
            var count = 1;
            foreach (var item in book.Where(a => a.Value.Count() == 3).OrderByDescending(a => a.Value.Values.Sum()))
            {
                Console.WriteLine($"{count}. {item.Key}; Players:");
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"###{item2.Key}: {item2.Value}");
                }
                count++;
            }
        }
    }
}

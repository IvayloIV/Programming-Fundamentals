using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, int>
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0
            };
            var junks = new Dictionary<string, int>();
            var characters = new Dictionary<string, string>
            {
                ["shards"] = "Shadowmourne",
                ["fragments"] = "Valanyr",
                ["motes"] = "Dragonwrath"
            };
            while (true)
            {
                var inputTokens = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < inputTokens.Length; i += 2)
                {
                    var itemQuantity = int.Parse(inputTokens[i]);
                    var item = inputTokens[i + 1].ToLower();
                    if (book.ContainsKey(item))
                    {
                        book[item] += itemQuantity;
                    }
                    else
                    {
                        if (!junks.ContainsKey(item))
                        {
                            junks[item] = 0;
                        }
                        junks[item] += itemQuantity;
                    }
                    if (book.Any(a => a.Value >= 250))
                    {
                        foreach (var item2 in book.Where(a => a.Value >= 250))
                        {
                            Console.WriteLine($"{characters[item2.Key]} obtained!");
                            book[item2.Key] -= 250;
                            break;
                        }
                        foreach (var item2 in book.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                        {
                            Console.WriteLine($"{item2.Key}: {item2.Value}");
                        }
                        foreach (var item2 in junks.OrderBy(a => a.Key))
                        {
                            Console.WriteLine($"{item2.Key}: {item2.Value}");
                        }
                        return;
                    }
                }
            }       
        }
    }
}

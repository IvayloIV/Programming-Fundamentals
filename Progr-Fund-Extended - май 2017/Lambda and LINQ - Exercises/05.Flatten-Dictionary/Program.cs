using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, string>>();
            var flatterBook = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(' ').ToArray();
                if (inputTokens.Count() == 3)
                {
                    var key = inputTokens[0];
                    var innerKey = inputTokens[1];
                    var innerValue = inputTokens[2];
                    if (!book.ContainsKey(key))
                    {
                        book[key] = new Dictionary<string, string>();
                    }
                    book[key][innerKey] = innerValue;
                }
                else if (inputTokens[0] == "flatten")
                {
                    var element = inputTokens[1];
                    foreach (var item in book.Where(a => a.Key == element))
                    {
                        if (!flatterBook.ContainsKey(item.Key))
                        {
                            flatterBook[item.Key] = new List<string>();
                        }
                        foreach (var item2 in item.Value)
                        {
                            flatterBook[item.Key].Add($"{item2.Key}{item2.Value}");
                        }
                    }
                    book[element] = new Dictionary<string, string>();
                }
            }
            foreach (var item in book.OrderByDescending(a => a.Key.Length))
            {
                Console.WriteLine(item.Key);
                var count = 1;
                foreach (var item2 in item.Value.OrderBy(a => a.Key.Length))
                {
                    Console.WriteLine($"{count}. {item2.Key} - {item2.Value}");
                    count++;
                }
                if (flatterBook.ContainsKey(item.Key))
                {
                    foreach (var item3 in flatterBook[item.Key])
                    {
                        Console.WriteLine($"{count}. {item3}");
                        count++;
                    }
                }
            }
        }
    }
}

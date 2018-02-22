using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputTokens[0];
                var shell = inputTokens[1].Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!int.TryParse(shell[0], out int r))
                {
                    if (!book.ContainsKey(shell[0]))
                    {
                        continue;
                    }
                    if (!book.ContainsKey(name))
                    {
                        book[name] = new List<int>();
                    }
                    book[name].AddRange(book[shell[0]]);
                }
                else
                {
                    if (!book.ContainsKey(name))
                    {
                        book[name] = new List<int>();
                    }
                    foreach (var item in shell)
                    {
                        book[name].Add(int.Parse(item));
                    }
                }
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
            }
        }
    }
}

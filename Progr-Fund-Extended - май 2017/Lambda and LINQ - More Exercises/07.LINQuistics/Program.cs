using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LINQuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                if (input.Contains('.'))
                {
                    var tokens = input.Split(new string[] { ".", "()" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var collectionName = tokens[0];
                    if (!book.ContainsKey(collectionName))
                    {
                        book[collectionName] = new List<string>();
                    }
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        if (!book[collectionName].Contains(tokens[i]))
                        {
                            book[collectionName].Add(tokens[i]);
                        }
                    }
                }
                else if (int.TryParse(input, out int t))
                {
                    foreach (var item in book.OrderByDescending(a => a.Value.Count()))
                    {
                        foreach (var item2 in item.Value.OrderBy(a => a.Length).Take(t))
                        {
                            Console.WriteLine($"* {item2}");
                        }
                        break;
                    }
                }
                else
                {
                    if (!book.ContainsKey(input))
                    {
                        continue;
                    }
                    foreach (var item in book.Where(a => a.Key == input))
                    {
                        foreach (var item2 in item.Value.OrderByDescending(a => a.Count()).ThenByDescending(a => a.Distinct().Count()))
                        {
                            Console.WriteLine($"* {item2}");
                        }
                    }
                }
            }
            var typeOfOutput = Console.ReadLine().Split(' ').ToArray();
            var metName = typeOfOutput[0];
            foreach (var item in book.Where(a => a.Value.Contains(metName)).OrderByDescending(a => a.Value.Count()).ThenByDescending(a => a.Value.Min(b => b.Length)))
            {
                if (typeOfOutput[1] == "collection")
                {
                    Console.WriteLine(item.Key);
                }
                else
                {
                    Console.WriteLine(item.Key);
                    foreach (var item2 in item.Value.OrderByDescending(a => a.Length))
                    {
                        Console.WriteLine($"* {item2}");
                    }
                }
            }
        }
    }
}

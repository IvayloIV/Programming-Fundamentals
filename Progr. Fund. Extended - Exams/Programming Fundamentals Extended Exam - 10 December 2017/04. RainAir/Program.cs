using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<long>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "I believe I can fly!")
                {
                    break;
                }

                Match findingTwoElements = Regex.Match(input, @"^(.*?) = (.*?)$");

                if (findingTwoElements.Success)
                {
                    var firstName = findingTwoElements.Groups[1].Value;
                    var secoundName = findingTwoElements.Groups[2].Value;
                    book[firstName] = new List<long>();
                    book[firstName].AddRange(book[secoundName]);
                    continue;
                }

                var splitInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = splitInput[0];

                if (!book.ContainsKey(name))
                {
                    book[name] = new List<long>();
                }
                for (int i = 1; i < splitInput.Length; i++)
                {
                    book[name].Add(long.Parse(splitInput[i]));
                }
            }

            foreach (var item in book.OrderByDescending(a => a.Value.Count()).ThenBy(a => a.Key))
            {
                Console.WriteLine($"#{item.Key} ::: {string.Join(", ", item.Value.OrderBy(a => a))}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var partisitants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var book = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "dawn")
                {
                    break;
                }

                var currentInput = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = currentInput[0];
                var song = currentInput[1];
                var aware = currentInput[2];

                if (!partisitants.Contains(name))
                {
                    continue;
                }

                if (!songs.Contains(song))
                {
                    continue;
                }

                if (!book.ContainsKey(name))
                {
                    book[name] = new List<string>();
                }

                if (book[name].All(a => a != aware))
                {
                    book[name].Add(aware);
                }
            }

            if (book.Count() == 0)
            {
                Console.WriteLine($"No awards");
            }

            foreach (var item in book.OrderByDescending(a => a.Value.Count()).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()} awards");
                foreach (var item2 in item.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{item2}");
                }
            }
        }
    }
}

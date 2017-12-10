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
            var names = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var songs = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var book = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "dawn")
                {
                    break;
                }
                var currentInput = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var currentName = currentInput[0];
                var currentSong = currentInput[1];
                var currentAwards = currentInput[2];

                if (!names.Contains(currentName) || !songs.Contains(currentSong))
                {
                    continue;
                }

                if (!book.ContainsKey(currentName))
                {
                    book[currentName] = new List<string>();
                }
                if (book[currentName].All(a => a != currentAwards))
                {
                    book[currentName].Add(currentAwards);
                }
            }

            if (book.Count() == 0)
            {
                Console.WriteLine($"No awards");
                return;
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

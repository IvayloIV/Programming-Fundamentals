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
            Dictionary<string, List<string>> book = new Dictionary<string, List<string>>();
            var names = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries).ToList();
            var songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            book = AddItemInBook(names, songs, book);
            
            PrintResult(book);
        }

        private static Dictionary<string, List<string>> AddItemInBook(List<string> names, List<string> songs, Dictionary<string, List<string>> book)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "dawn")
                {
                    break;
                }

                var inputTokens = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = inputTokens[0];
                var song = inputTokens[1];
                var award = inputTokens[2];

                if (!names.Contains(name))
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
                if (book[name].All(a => a != award))
                {
                    book[name].Add(award);
                }
            }
            return book;
        }

        private static void PrintResult(Dictionary<string, List<string>> book)
        {
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

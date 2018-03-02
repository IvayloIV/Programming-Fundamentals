using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<String, Dictionary<String, long>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var splitedBui = input.Split('\\').ToArray();
                var spliByu = splitedBui[splitedBui.Length - 1].Split(';').ToArray();
                var root = splitedBui[0];
                var fileExtension = spliByu[0];
                var size = long.Parse(spliByu[1]);

                if (!book.ContainsKey(root))
                {
                    book[root] = new Dictionary<string, long>();
                }

                book[root][fileExtension] = size;
            }

            var progress = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var currentRoot = progress[2];
            var extension = progress[0];

            var isOkey = false;
            foreach (var item in book.Where(a => a.Key == currentRoot))
            {
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    if (item2.Key.EndsWith(extension))
                    {
                        isOkey = true;
                        Console.WriteLine($"{item2.Key} - {item2.Value} KB");
                    }
                }
            }
            if (!isOkey)
            {
                Console.WriteLine($"No");
            }
        }
    }
}

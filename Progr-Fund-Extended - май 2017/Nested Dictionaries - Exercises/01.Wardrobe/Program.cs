using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, int>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new string[] { " -> " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var color = tokens[0];
                var clotches = tokens[1].Split(',').ToArray();
                if (!book.ContainsKey(color))
                {
                    book[color] = new Dictionary<string, int>();
                }
                foreach (var clotche in clotches)
                {
                    if (!book[color].ContainsKey(clotche))
                    {
                        book[color][clotche] = 0;
                    }
                    book[color][clotche]++;
                }            
            }
            var typeFind = Console.ReadLine().Split(' ').ToArray();
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {
                    Console.Write($"* {item2.Key} - {item2.Value}");
                    if (typeFind[0] == item.Key && typeFind[1] == item2.Key)
                    {
                        Console.WriteLine($" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

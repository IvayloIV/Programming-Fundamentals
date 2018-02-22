using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_Key_Value_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var value = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var currentKey = tokens[0];
                var currentValues = tokens[1].Split(';').ToArray();
                if (currentKey.IndexOf(key) == -1)
                {
                    continue;
                }
                if (!book.ContainsKey(currentKey))
                {
                    book[currentKey] = new List<string>();
                }
                foreach (var item in currentValues)
                {
                    if (item.IndexOf(value) == -1)
                    {
                        continue;
                    }
                    book[currentKey].Add(item);
                }
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-{item2}");
                }
            }
        }
    }
}

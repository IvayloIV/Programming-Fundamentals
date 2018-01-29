using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, long>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                Match inputTokens = Regex.Match(input, @"^(.*?)\\(?:(?:.*?)\\)*(.*?)\;([0-9]+)$");
                var root = inputTokens.Groups[1].Value;
                var fileNameExten = inputTokens.Groups[2].Value;
                var fileSize = long.Parse(inputTokens.Groups[3].Value);

                if (!book.ContainsKey(root))
                {
                    book[root] = new Dictionary<string, long>();
                }
                book[root][fileNameExten] = fileSize;
            }
            var findingValue = Console.ReadLine().Split(new string[] { " in "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var currentExtendion = findingValue[0];
            var currentRoot = findingValue[1];
            var count = 0;
            foreach (var item in book.Where(a => a.Key == currentRoot))
            {
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    if (item2.Key.EndsWith(currentExtendion))
                    {
                        Console.WriteLine($"{item2.Key} - {item2.Value} KB ");
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"No");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                Match findingIsCorrect = Regex.Match(input, @"^(.*?)\s@(.*?)\s([0-9]+)\s([0-9]+)$");
                if (!findingIsCorrect.Success)
                {
                    continue;
                }
                var nameSinger = findingIsCorrect.Groups[1].Value;
                var place = findingIsCorrect.Groups[2].Value.Trim();
                var ticketPrice = long.Parse(findingIsCorrect.Groups[3].Value);
                var ticketCount = long.Parse(findingIsCorrect.Groups[4].Value);
                if (!book.ContainsKey(place))
                {
                    book[place] = new Dictionary<string, long>();
                }
                if (!book[place].ContainsKey(nameSinger))
                {
                    book[place][nameSinger] = 0;
                }
                book[place][nameSinger] += (ticketPrice * ticketCount);
            }
            foreach (var item in book)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"#  {item2.Key} -> {item2.Value}");
                }
            }
        }
    }
}

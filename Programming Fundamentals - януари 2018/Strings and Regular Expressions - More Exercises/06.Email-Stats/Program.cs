using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Email_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                var email = Console.ReadLine();
                Match matchEmail = Regex.Match(email, @"^(?<name>[A-Za-z]{5,})@(?<domain>[a-z]{3,}(?:\.com|\.bg|\.org))$");
                if (!matchEmail.Success)
                {
                    continue;
                }
                var name = matchEmail.Groups["name"].Value;
                var domain = matchEmail.Groups["domain"].Value;
                if (!book.ContainsKey(domain))
                {
                    book[domain] = new List<string>();
                }
                if (book[domain].All(a => a != name))
                {
                    book[domain].Add(name);
                }
            }
            foreach (var item in book.OrderByDescending(a => a.Value.Count()))
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"### {item2}");
                }
            }
        }
    }
}

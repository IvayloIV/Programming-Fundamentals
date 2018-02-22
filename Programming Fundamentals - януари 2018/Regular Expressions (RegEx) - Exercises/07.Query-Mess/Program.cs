using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END") break;
                var book = new Dictionary<string, List<string>>();
                MatchCollection finding = Regex.Matches(input, @"([^&?=]+)=([^&?=]+)");
                foreach (Match item in finding)
                {
                    var key = item.Groups[1].Value;
                    var value = item.Groups[2].Value;

                    key = Regex.Replace(key, @"(%20|\+)+", " ").Trim();
                    value = Regex.Replace(value, @"(%20|\+)+", " ").Trim();
                    if (!book.ContainsKey(key))
                    {
                        book[key] = new List<string>(); 
                    }
                    book[key].Add(value);
                }
                foreach (var item in book)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }
                Console.WriteLine();
            }
        }
    }
}

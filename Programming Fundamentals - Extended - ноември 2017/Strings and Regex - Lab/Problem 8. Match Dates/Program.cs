using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_8.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            MatchCollection finding = Regex.Matches(input, @"\b(?<day>\d{2})([-.\/])(?<mount>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

            foreach (Match item in finding)
            {
                Console.Write($"Day: {item.Groups["day"].Value},");
                Console.Write($" Month: {item.Groups["mount"].Value},");
                Console.WriteLine($" Year: {item.Groups["year"].Value}");
            }
        }
    }
}

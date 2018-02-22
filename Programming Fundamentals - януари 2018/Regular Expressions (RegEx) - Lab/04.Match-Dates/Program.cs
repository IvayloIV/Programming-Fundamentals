using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            MatchCollection finding = Regex.Matches(input, @"\b(?<day>[0-9]{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");
            foreach (Match item in finding)
            {
                Console.WriteLine($"Day: {item.Groups["day"].Value}, Month: {item.Groups["month"].Value}, Year: {item.Groups["year"].Value}");
            }
        }
    }
}

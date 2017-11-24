using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_10.Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                Match finding = Regex.Match(input, @"(.*?)<a\s?href=(.*?)>(.*?)<\/a>(.*)");

                if (finding.Success)
                {
                    var tt = finding.Value.Replace(finding.Value, $"{finding.Groups[1].Value}[URL href={finding.Groups[2].Value}]{finding.Groups[3].Value}[/URL]{finding.Groups[4].Value}");
                    Console.WriteLine(tt);
                    continue;
                }
                Console.WriteLine(input);
            }
        }
    }
}

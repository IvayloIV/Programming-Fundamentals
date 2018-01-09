using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var input = Console.ReadLine();

            MatchCollection findingPears = Regex.Matches(input, @"(.*?)([0-9]+)");

            StringBuilder allText = FillText(input, findingPears);

            PrintResult(allText);
        }

        private static void PrintResult(StringBuilder allText)
        {
            var unLetter = allText.ToString().ToCharArray().Distinct().ToList();
            Console.WriteLine($"Unique symbols used: {unLetter.Count()}");
            Console.WriteLine(allText.ToString());
        }

        private static StringBuilder FillText(string input, MatchCollection findingPears)
        {
            StringBuilder allText = new StringBuilder();
            foreach (Match item in findingPears)
            {
                var text = item.Groups[1].Value.ToUpper();
                var number = int.Parse(item.Groups[2].Value);
                for (int i = 0; i < number; i++)
                {
                    allText.Append(text);
                }
            }
            return allText;
        }
    }
}

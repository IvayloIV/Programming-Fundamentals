using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThreeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var attackers = new List<string>();
            var destroyers = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var text = Console.ReadLine();
                MatchCollection findingLetters = Regex.Matches(text, @"[starSTAR]");
                var count = findingLetters.Count;
                var replacedText = "";
                for (int q = 0; q < text.Length; q++)
                {
                    replacedText += (char)(text[q] - count);
                }
                Match findingShits = Regex.Match(replacedText, @"@(?<name>[A-Za-z]+)([^@!:>-]*):[0-9]+([^@!:>-]*)!(?<typeText>[AD])!([^@!:>-]*)->[0-9]+([^@!:>-]*)");
                var planetName = findingShits.Groups["name"].Value;
                var typePlannet = findingShits.Groups["typeText"].Value;
                if (typePlannet == "A")
                {
                    attackers.Add(planetName);
                }
                else if (typePlannet == "D")
                {
                    destroyers.Add(planetName);
                }
            }
            Console.WriteLine($"Attacked planets: {attackers.Count()}");
            foreach (var item in attackers.OrderBy(a => a))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyers.Count()}");
            foreach (var item in destroyers.OrderBy(a => a))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}

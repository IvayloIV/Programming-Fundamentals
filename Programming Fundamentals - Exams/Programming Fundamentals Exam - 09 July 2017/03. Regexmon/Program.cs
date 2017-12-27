using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var count = 0;
            var skips = 0;
            while (true)
            {
                var curretText = new string(text.Skip(skips).ToArray());
                MatchCollection findingDidi = MatchText(curretText, count);

                if (findingDidi.Count == 0)
                {
                    break;
                }
                var firstMatch = findingDidi[0].Value;
                Console.WriteLine(firstMatch);
                skips += curretText.IndexOf(firstMatch) + firstMatch.Length;
                count++;
            }
        }

        private static MatchCollection MatchText(string curretText, int count)
        {
            if (count % 2 == 0)
            {
                return Regex.Matches(curretText, @"[^A-Za-z\-]+");
            }
            return Regex.Matches(curretText, @"[A-Za-z]+\-[A-Za-z]+");
        }
    }
}

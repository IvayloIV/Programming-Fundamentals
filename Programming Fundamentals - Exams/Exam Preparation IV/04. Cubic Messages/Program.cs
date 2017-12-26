using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4___Cubic_s_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var text = Console.ReadLine();

                if (text == "Over!")
                {
                    break;
                }

                var n = int.Parse(Console.ReadLine());

                Match findingText = Regex.Match(text, @"^([0-9]+)([A-Za-z]+)([^A-Za-z]*)$");

                if (!findingText.Success)
                {
                    continue;
                }

                var middle = findingText.Groups[2].Value;

                if (middle.Length != n)
                {
                    continue;
                }

                var book = new List<int>();
                var afterText = "";
                var leftText = findingText.Groups[1].Value;
                MatchCollection leftTextFinding = Regex.Matches(leftText, @"[0-9]");

                foreach (Match item in leftTextFinding)
                {
                    book.Add(int.Parse(item.Value));
                }
                var rightText = findingText.Groups[3].Value;
                MatchCollection rightTextFinding = Regex.Matches(rightText, @"[0-9]");
                foreach (Match item in rightTextFinding)
                {
                    book.Add(int.Parse(item.Value));
                }
                foreach (var item in book)
                {
                    if (item <= middle.Length - 1)
                    {
                        afterText += middle[item];
                    }
                    else
                    {
                        afterText += " ";
                    }
                }
                Console.WriteLine($"{middle} == {afterText}");
            }
        }
    }
}

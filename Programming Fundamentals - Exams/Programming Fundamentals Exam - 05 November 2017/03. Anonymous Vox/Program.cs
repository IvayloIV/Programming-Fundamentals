using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var text = Console.ReadLine();
            var replacemant = Console.ReadLine();

            MatchCollection findingText = Regex.Matches(text, @"([A-Za-z]+)(.*)(\1)");
            MatchCollection findingReplacemant = Regex.Matches(replacemant, @"{(.*?)}");

            text = ReplceAllMathces(findingText, findingReplacemant, text);

            Console.WriteLine(text);
        }

        private static string ReplceAllMathces(MatchCollection findingText, MatchCollection findingReplacemant, string text)
        {
            var count = 0;
            foreach (Match item in findingText)
            {
                var currentReplace = findingReplacemant[count].Groups[1].Value;

                var curretnFindText = item.Groups[2].Value;
                var index = text.IndexOf(curretnFindText);
                text = AddPartsToString(text, index, currentReplace, curretnFindText);

                count++;
            }
            return text;
        }

        private static string AddPartsToString(string text, int index, string currentReplace, string curretnFindText)
        {
            var newText = new string(text.Take(index).ToArray());
            newText += currentReplace;
            newText += new string(text.Skip(curretnFindText.Length + index).ToArray());
            return newText;
        }
    }
}

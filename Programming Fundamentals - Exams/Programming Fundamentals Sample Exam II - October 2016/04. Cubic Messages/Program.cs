using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }
                var num = int.Parse(Console.ReadLine());

                Match findingInput = Regex.Match(input, @"^[0-9]*([A-Za-z]+)[^A-Za-z]*$");
                if (!findingInput.Success)
                {
                    continue;
                }

                var text = findingInput.Groups[1].Value;
                if (text.Length != num)
                {
                    continue;
                }

                MatchCollection numbers = Regex.Matches(input, @"[0-9]");

                var encriptText = ConventNumbersInLetters(numbers, text);

                Console.WriteLine($"{text} == {encriptText}");
            }
        }

        private static object ConventNumbersInLetters(MatchCollection numbers, string text)
        {
            var encriptText = "";
            foreach (Match item in numbers)
            {
                var currentNum = int.Parse(item.Value);
                if (currentNum > text.Length - 1 || currentNum < 0)
                {
                    encriptText += " ";
                }
                else
                {
                    encriptText += text[currentNum];
                }
            }
            return encriptText;
        }
    }
}

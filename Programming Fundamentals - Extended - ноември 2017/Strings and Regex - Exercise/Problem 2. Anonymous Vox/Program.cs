using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_2.Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            MatchCollection finding = Regex.Matches(input, @"([A-Za-z]+)(.*)\1");
            var words = Console.ReadLine();
            MatchCollection finding2 = Regex.Matches(words, @"{(.*?)}");

            var currentWords = new List<string>();
            foreach (Match item in finding2)
            {
                currentWords.Add(item.Groups[1].Value);
            }

            var totalWord = 0;
            foreach (Match item in finding)
            {
                if (totalWord > currentWords.Count - 1)
                {
                    totalWord = 0;
                }
                var currentFind = item.Groups[2].Value;
                var n = input.IndexOf(currentFind);
                var start = new string(input.Take(n).ToArray());
                var end = new string(input.Skip(n + currentFind.Length).ToArray());
                input = start + currentWords[totalWord] + end;

                totalWord++;
            }
            Console.WriteLine(input);
        }
    }
}

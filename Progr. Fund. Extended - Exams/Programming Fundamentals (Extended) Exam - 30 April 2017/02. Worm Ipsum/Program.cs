using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"^([A-Z](?:.*?)\.)";

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Worm Ipsum")
                {
                    break;
                }

                Match findingSentence = Regex.Match(input, regex);

                if (!findingSentence.Success)
                {
                    continue;
                }

                var findingValue = findingSentence.Groups[1].Value;
                if (findingValue != input)
                {
                    continue;
                }
                MatchCollection findingWords = Regex.Matches(input, @"\w+");

                if (findingWords.Count == 0)
                {
                    Console.WriteLine(input);
                    continue;
                }

                foreach (Match word in findingWords)
                {
                    var book = new Dictionary<string, int>();
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!book.ContainsKey(word.Value[i].ToString()))
                        {
                            book[word.Value[i].ToString()] = 0;
                        }
                        book[word.Value[i].ToString()]++;                       
                    }
                    var currentKey = "";
                    if (book.All(a => a.Value == 1)) {
                        continue;
                    }
                    foreach (var item in book.OrderByDescending(a => a.Value))
                    {
                        currentKey = item.Key;
                        break;
                    }
                    var replacer = "";
                    for (int i = 0; i < word.Length; i++)
                    {
                        replacer += currentKey;
                    }
                    input = input.Replace(word.Value, replacer);
                }
                Console.WriteLine(input);
            }
        }
    }
}

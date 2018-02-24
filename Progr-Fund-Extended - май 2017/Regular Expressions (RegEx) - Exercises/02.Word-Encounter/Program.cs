using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().ToCharArray();

            var allValidWords = new List<string>();
            while (true)
            {
                var sentence = Console.ReadLine();
                if (sentence == "end")
                {
                    break;
                }
                Match validSentence = Regex.Match(sentence, @"^[A-Z](.*?)[!?\.]$");
                if (!validSentence.Success)
                {
                    continue;
                }
                MatchCollection allWords = Regex.Matches(sentence, @"\w+");
                foreach (Match word in allWords)
                {
                    var timeRepeat = 0;
                    for (int i = 0; i < word.Value.Length; i++)
                    {
                        if (word.Value[i] == arr[0])
                        {
                            timeRepeat++;
                        }
                    }
                    if (timeRepeat >= int.Parse(arr[1].ToString()))
                    {
                        allValidWords.Add(word.Value);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", allValidWords));
        }
    }
}

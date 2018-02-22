using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { " ", "/", "\\", "(", ")" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var words = new List<string>();
            foreach (var item in input)
            {
                Match findWord = Regex.Match(item, @"^[A-Za-z][A-Za-z0-9_]{2,24}$");
                if (!findWord.Success) continue;
                words.Add(item);
            }
            var firstElement = "";
            var secondName = "";
            var bestLength = 0;
            for (int i = 0; i < words.Count() - 1; i++)
            {
                var sum = words[i].Length + words[i + 1].Length;
                if (sum > bestLength)
                {
                    firstElement = words[i];
                    secondName = words[i + 1];
                    bestLength = sum;
                }
            }
            Console.WriteLine(firstElement);
            Console.WriteLine(secondName);
        }
    }
}

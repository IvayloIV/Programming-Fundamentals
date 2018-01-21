using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var privateKey = Console.ReadLine();
            var book = new Dictionary<string, List<string>>();
            book = MakeLoops(book, privateKey);
            PrintResult(book);
        }

        private static Dictionary<string, List<string>> MakeLoops(Dictionary<string, List<string>> book, string privateKey)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                Match inputTokens = Regex.Match(input, @"^TO:\s([A-Z]*); MESSAGE:\s(.*?);$");

                if (!inputTokens.Success)
                {
                    continue;
                }

                var name = inputTokens.Groups[1].Value;
                var encriptMessage = EncriptMessage(input, privateKey);
                if (!book.ContainsKey(name))
                {
                    book[name] = new List<string>();
                }
                book[name].Add(encriptMessage);
            }
            return book;
        }

        private static void PrintResult(Dictionary<string, List<string>> book)
        {
            foreach (var item in book.OrderBy(a => a.Key))
            {
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2);
                }
            }
        }

        private static string EncriptMessage(string input, string privateKey)
        {
            var newMessage = "";
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                newMessage += (char)(char.Parse(input[i].ToString()) + int.Parse(privateKey[count].ToString()));
                count++;
                if (count > privateKey.Length - 1)
                {
                    count = 0;
                }
            }
            return newMessage;
        }
    }
}

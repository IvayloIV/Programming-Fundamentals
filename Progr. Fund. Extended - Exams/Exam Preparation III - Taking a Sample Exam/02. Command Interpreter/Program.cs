using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var inputTokens = input.Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputTokens[0] == "reverse" || inputTokens[0] == "sort")
                {
                    book = ReverseAndSortArr(book, inputTokens);
                }
                else if (inputTokens[0] == "rollLeft" || inputTokens[0] == "rollRight")
                {
                    book = RollBookArr(book, inputTokens);
                }
            }
            Console.WriteLine("[" + string.Join(", ", book) + "]");
        }

        private static List<string> RollBookArr(List<string> book, string[] inputTokens)
        {
            if (int.Parse(inputTokens[1]) < 0)
            {
                Console.WriteLine($"Invalid input parameters.");
                return book;
            }

            for (int i = 0; i < int.Parse(inputTokens[1]) % book.Count(); i++)
            {
                if (inputTokens[0] == "rollLeft")
                {
                    var firstElement = book[0];
                    book.RemoveAt(0);
                    book.Add(firstElement);
                }
                else if (inputTokens[0] == "rollRight")
                {
                    var lastElement = book[book.Count() - 1];
                    book.RemoveAt(book.Count() - 1);
                    book.Reverse();
                    book.Add(lastElement);
                    book.Reverse();
                }
            }
            return book;
        }

        private static List<string> ReverseAndSortArr(List<string> book, string[] inputTokens)
        {
            var start = int.Parse(inputTokens[2]);
            var count = int.Parse(inputTokens[4]);

            if (start < 0 || start > book.Count() - 1 || count < 0 || start + count > book.Count()) {
                Console.WriteLine("Invalid input parameters.");
                return book;
            }

            var leftPart = book.Take(start).ToList();
            var middlePart = book.Skip(start).Take(count).ToList();
            var rightPart = book.Skip(start + count).ToList();

            if (inputTokens[0] == "reverse")
            {
                middlePart.Reverse();
            }
            else if (inputTokens[0] == "sort")
            {
               middlePart.Sort();
            }
            leftPart = leftPart.Concat(middlePart).ToList();
            return leftPart.Concat(rightPart).ToList();
        }
    }
}

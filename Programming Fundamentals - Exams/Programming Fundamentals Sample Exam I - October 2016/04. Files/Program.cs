using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, Dictionary<string, long>>();

            book = AddParamsInBook(n, book);

            PrintResult(book);
        }

        private static Dictionary<string, Dictionary<string, long>> AddParamsInBook(int n, 
            Dictionary<string, Dictionary<string, long>> book)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var root = input[0];
                var splitInput = input[input.Length - 1]
                    .Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var fillNameExtension = splitInput[0];
                var size = long.Parse(splitInput[1]);

                if (!book.ContainsKey(root))
                {
                    book[root] = new Dictionary<string, long>();
                }

                book[root][fillNameExtension] = size;
            }
            return book;
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> book)
        {
            var secoundInput = Console.ReadLine()
                .Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var outputRoot = secoundInput[1];
            var extension = secoundInput[0];

            var isOkey = false;
            foreach (var item in book.Where(a => a.Key == outputRoot))
            {
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    if (item2.Key.EndsWith(extension))
                    {
                        isOkey = true;
                        Console.WriteLine($"{item2.Key} - {item2.Value} KB");
                    }
                }
            }
            if (!isOkey)
            {
                Console.WriteLine($"No");
            }
        }
    }
}

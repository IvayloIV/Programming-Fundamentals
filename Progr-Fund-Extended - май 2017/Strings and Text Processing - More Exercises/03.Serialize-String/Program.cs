using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var book = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (book.Contains(input[i])) continue;
                var currentChar = input[i];
                Console.Write($"{currentChar}:{i}");
                if (i >= input.Length - 1) continue;
                var index = i + 1;
                index = input.IndexOf(currentChar, index);
                while (index != -1)
                {
                    Console.Write($"/{index}");
                    if (index >= input.Length - 1) break;
                    index = input.IndexOf(currentChar, index + 1);
                }
                book += input[i];
                Console.WriteLine();
            }
        }
    }
}

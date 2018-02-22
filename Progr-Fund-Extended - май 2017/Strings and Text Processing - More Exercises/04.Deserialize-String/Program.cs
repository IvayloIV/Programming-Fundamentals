using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<int, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new string[] { ":", "/" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var currentChar = inputTokens[0];
                for (int i = 1; i < inputTokens.Length; i++)
                {
                    book[int.Parse(inputTokens[i])] = currentChar;
                }
            }
            foreach (var item in book.OrderBy(a => a.Key))
            {
                Console.Write(item.Value);
            }
            Console.WriteLine();
        }
    }
}

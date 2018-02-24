using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                book[inputTokens[0]] = inputTokens[1];
            }
            var defaultValue = Console.ReadLine();
            foreach (var item in book.Where(a => a.Value != "null").OrderByDescending(a => a.Value.Length))
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
            foreach (var item in book.Where(a => a.Value == "null"))
            {
                Console.WriteLine($"{item.Key} <-> {defaultValue}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "quit") {
                    break;
                }

                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var contry = inputTokens[0];
                var name = inputTokens[1];
                var days = long.Parse(inputTokens[2]);

                if (!book.ContainsKey(contry)) {
                    book[contry] = new Dictionary<string, long>();
                }
                if (!book[contry].ContainsKey(name)) {
                    book[contry][name] = 0;
                }
                book[contry][name] = days;
            }
            PrintResult(book);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, long>> book)
        {
            foreach (var item in book.OrderByDescending(a => a.Value.Count()))
            {
                Console.WriteLine($"Country: {item.Key}");
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"**{item2.Key} : {item2.Value}");
                }
            }
        }
    }
}

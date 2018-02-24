using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Register_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, DateTime>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputTokens[0];
                var date = DateTime.ParseExact(inputTokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                book[name] = date;
            }
            book = book.Reverse().OrderBy(a => a.Value).Take(5).OrderByDescending(a => a.Value).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in book)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}

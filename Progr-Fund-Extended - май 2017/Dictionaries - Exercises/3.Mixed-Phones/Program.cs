using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, long>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputTokens[0].All(a => a >= 48 && a <= 57))
                {
                    book[inputTokens[1]] = long.Parse(inputTokens[0]);
                }
                else
                {
                    book[inputTokens[0]] = long.Parse(inputTokens[1]);
                }
            }
            foreach (var item in book.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

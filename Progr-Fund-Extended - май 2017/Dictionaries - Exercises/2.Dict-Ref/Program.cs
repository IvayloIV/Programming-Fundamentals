using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, long>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = inputTokens[0];
                if (int.TryParse(inputTokens[1], out int num))
                {
                    book[name] = num;
                }
                else
                {
                    var secondName = inputTokens[1];
                    if (book.All(a => a.Key != secondName))
                    {
                        continue;
                    }
                    var currentNum = book[secondName];
                    book[name] = currentNum;
                }
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}

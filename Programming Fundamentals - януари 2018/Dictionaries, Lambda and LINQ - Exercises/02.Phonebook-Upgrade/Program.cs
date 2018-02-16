using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                else if (input == "ListAll")
                {
                    foreach (var item in book.OrderBy(a => a.Key))
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    continue;
                }
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var type = inputTokens[0];
                var name = inputTokens[1];
                if (type == "A")
                {
                    var phone = inputTokens[2];
                    book[name] = phone;
                }
                else
                {
                    if (!book.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {book[name]}");
                    }
                }
            }
        }
    }
}

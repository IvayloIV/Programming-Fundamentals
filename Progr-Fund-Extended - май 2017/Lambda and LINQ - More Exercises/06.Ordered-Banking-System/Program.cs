using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, decimal>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var bankName = inputTokens[0];
                var personName = inputTokens[1];
                var money = decimal.Parse(inputTokens[2]);
                if (!book.ContainsKey(bankName))
                {
                    book[bankName] = new Dictionary<string, decimal>();
                }
                if (!book[bankName].ContainsKey(personName))
                {
                    book[bankName][personName] = 0M;
                }
                book[bankName][personName] += money;
            }
            foreach (var item in book.OrderByDescending(a => a.Value.Values.Sum()).ThenByDescending(a => a.Value.Values.Max()))
            {
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{item2.Key} -> {item2.Value} ({item.Key})");
                }
            }
        }
    }
}

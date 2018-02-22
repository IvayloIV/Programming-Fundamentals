using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
    class Program
    {
        class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }
            public BankAccount(string name, string bank, decimal balance)
            {
                Name = name;
                Bank = bank;
                Balance = balance;
            }
        }
        static void Main(string[] args)
        {
            var book = new List<BankAccount>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                book.Add(new BankAccount(inputTokens[1], inputTokens[0], decimal.Parse(inputTokens[2])));
            }
            foreach (var item in book.OrderByDescending(a => a.Balance).ThenBy(a => a.Bank))
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }
    }
}

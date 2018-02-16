using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                var quantity = int.Parse(Console.ReadLine());
                if (!book.ContainsKey(input))
                {
                    book[input] = 0;
                }
                book[input] += quantity;
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "report")
                {
                    break;
                }
                var inputTokens = input.Split('|').ToArray();
                var town = inputTokens[0];
                var contry = inputTokens[1];
                var population = long.Parse(inputTokens[2]);
                if (!book.ContainsKey(contry))
                {
                    book[contry] = new Dictionary<string, long>();
                }
                if (!book[contry].ContainsKey(town))
                {
                    book[contry][town] = 0;
                }
                book[contry][town] += population;
            }
            foreach (var item in book.OrderByDescending(a => a.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"=>{item2.Key}: {item2.Value}");
                }
            }
        }
    }
}

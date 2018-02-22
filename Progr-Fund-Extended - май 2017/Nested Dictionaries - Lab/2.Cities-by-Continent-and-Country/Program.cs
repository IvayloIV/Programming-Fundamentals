using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var mainland = input[0];
                var contry = input[1];
                var town = input[2];
                if (!book.ContainsKey(mainland))
                {
                    book[mainland] = new Dictionary<string, List<string>>();
                }
                if (!book[mainland].ContainsKey(contry))
                {
                    book[mainland][contry] = new List<string>();
                }
                book[mainland][contry].Add(town);
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.Key} -> {string.Join(", ", item2.Value)}");
                }
            }
        }
    }
}

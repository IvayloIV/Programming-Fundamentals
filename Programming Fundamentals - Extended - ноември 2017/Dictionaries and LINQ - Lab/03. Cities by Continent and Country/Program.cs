using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cities_by_Contine
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var cont = input[0];
                var contry = input[1];
                var town = input[2];

                if (!book.ContainsKey(cont))
                {
                    book[cont] = new Dictionary<string, List<string>>();
                }

                if (!book[cont].ContainsKey(contry))
                {
                    book[cont][contry] = new List<string>();
                }

                book[cont][contry].Add(town);
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

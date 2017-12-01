using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.ToLower()).ToArray();
            var book = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!book.ContainsKey(item))
                {
                    book[item] = 0;
                }
                book[item] += 1;
            }

            var lista = new List<string>();
            foreach (var item in book)
            {
                if (item.Value % 2 == 1)
                {
                    lista.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", lista));
        }
    }
}

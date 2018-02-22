using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, int>();
            var tokens = Console.ReadLine().Split(' ').ToArray();
            foreach (var item in tokens)
            {
                if (!book.ContainsKey(item.ToLower()))
                {
                    book[item.ToLower()] = 0;
                }
                book[item.ToLower()]++;
            }
            Console.WriteLine(string.Join(", ", book.Where(a => a.Value % 2 == 1).Select(a => a.Key)));
        }
    }
}

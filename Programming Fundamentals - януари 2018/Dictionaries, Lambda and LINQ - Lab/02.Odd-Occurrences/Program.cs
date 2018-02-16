using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().ToLower().Split(' ').ToList();
            var book = new Dictionary<string, int>();
            foreach (var item in arr)
            {
                if (!book.ContainsKey(item))
                {
                    book[item] = 0;
                }
                book[item]++;
            }
            var listBook = new List<string>();
            foreach (var item in book)
            {
                if (item.Value % 2 == 1)
                {
                    listBook.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", listBook));
        }
    }
}

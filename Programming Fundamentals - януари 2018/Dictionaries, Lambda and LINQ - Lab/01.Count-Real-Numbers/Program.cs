using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var book = new SortedDictionary<double, int>();
            foreach (var item in arr)
            {
                if (!book.ContainsKey(item))
                {
                    book[item] = 0;
                }
                book[item]++;
            }
            foreach (var item in book)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

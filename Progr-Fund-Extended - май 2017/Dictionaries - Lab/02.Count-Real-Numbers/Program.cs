using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new SortedDictionary<double, int>();
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (var item in input)
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

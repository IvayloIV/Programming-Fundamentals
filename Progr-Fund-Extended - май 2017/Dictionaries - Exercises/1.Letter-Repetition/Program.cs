using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<char, int>();
            var charArr = Console.ReadLine().ToCharArray();
            foreach (var item in charArr)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new List<int>();

            for (int i = 0; i < n; i++)
            {
                book.Add(int.Parse(Console.ReadLine()));               
            }
            Console.WriteLine($"Sum = {book.Sum()}");
            Console.WriteLine($"Min = {book.Min()}");
            Console.WriteLine($"Max = {book.Max()}");
            Console.WriteLine($"Average = {book.Average()}");
        }
    }
}

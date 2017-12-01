using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()
                .OrderByDescending(a => a)
                .Take(3)));
        }
    }
}

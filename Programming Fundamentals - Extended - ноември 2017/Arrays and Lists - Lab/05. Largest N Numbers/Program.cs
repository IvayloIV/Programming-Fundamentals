using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .OrderByDescending(a => a)
                .Take(int.Parse(Console.ReadLine()))));
        }
    }
}

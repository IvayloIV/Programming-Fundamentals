using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var item in arr.OrderByDescending(a => a).Take(3))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

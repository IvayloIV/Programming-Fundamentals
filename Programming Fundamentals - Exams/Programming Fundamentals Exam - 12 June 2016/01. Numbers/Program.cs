using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var average = arr.Average();
            arr = arr.Where(a => a > average).ToList();
            if (arr.Count() == 0)
            {
                Console.WriteLine("No");
                return;
            }
            Console.WriteLine(string.Join(" ", arr.OrderByDescending(a => a).Take(5).ToList()));
        }
    }
}

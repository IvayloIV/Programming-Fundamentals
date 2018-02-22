using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var average = arr.Average();
            arr = arr.Where(a => a >= average).ToList();
            var output = Console.ReadLine();
            if (output == "Min")
            {
                Console.WriteLine(arr.Min());
            }
            else if (output == "Max")
            {
                Console.WriteLine(arr.Max());
            }
            else
            {
                Console.WriteLine(string.Join(" ", arr.OrderBy(a => a)));
            }
        }
    }
}

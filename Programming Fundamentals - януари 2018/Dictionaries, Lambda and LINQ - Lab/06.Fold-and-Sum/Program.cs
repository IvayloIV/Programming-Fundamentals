using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = arr.Count() / 4;
            var upperNums = arr.Take(n).Reverse().ToList().Concat(arr.Skip(n * 3).Reverse().ToList()).ToList();
            var middleNums = arr.Skip(n).Take(2 * n).ToList();
            Console.WriteLine(string.Join(" ", upperNums.Select((x, index) => x + middleNums[index]).ToList()));
        }
    }
}

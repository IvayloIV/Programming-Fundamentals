using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var n = input.Count / 4;

            var letfPart = input.Take(n).Reverse().ToList();
            var middlePart = input.Skip(n).Take(n * 2).ToList();
            var rightPart = input.Skip(n * 3).Take(n).Reverse().ToList();

            var first = letfPart.Concat(rightPart).ToList();

            var output = new List<int>();
            for (int i = 0; i < middlePart.Count; i++)
            {
                output.Add(first[i] + middlePart[i]);
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}

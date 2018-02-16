using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(' ').ToList();
            var secondArr = Console.ReadLine().Split(' ').ToList();

            var allArr = firstArr.Concat(secondArr).ToList();
            var minLength = int.MaxValue;

            foreach (var item in allArr)
            {
                var itemAbs = Math.Abs(int.Parse(item));
                if (itemAbs.ToString().Length < minLength)
                {
                    minLength = itemAbs.ToString().Length;
                }
            }
            firstArr = firstArr.Where(a => Math.Abs(int.Parse(a)).ToString().Length == minLength).ToList();
            secondArr = secondArr.Where(a => Math.Abs(int.Parse(a)).ToString().Length == minLength).ToList();

            var outputArr = new List<string>();
            for (int i = 0; i < Math.Max(firstArr.Count(), secondArr.Count()); i++)
            {
                if (i <= secondArr.Count() - 1)
                {
                    outputArr.Add(secondArr[i]);
                }
                if (i <= firstArr.Count() - 1)
                {
                    outputArr.Add(firstArr[i]);
                }
            }
            Console.WriteLine(string.Join(" ", outputArr));
        }
    }
}

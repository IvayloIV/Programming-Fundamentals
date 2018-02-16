using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondArr = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var item in firstArr)
            {
                secondArr.RemoveAll(a => a == item);
            }
            var firstSum = firstArr.Sum();
            var secondSum = secondArr.Sum();
            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes. Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstSum - secondSum)}");
            }
        }
    }
}

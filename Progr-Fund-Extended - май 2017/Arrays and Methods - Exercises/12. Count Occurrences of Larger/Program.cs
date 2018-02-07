using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Count_Occurrences_of_Larger
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var currentNum = double.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > currentNum)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).Where(a => a % 2 == 0).ToList();
            var average = nums.Average();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] > average) nums[i]++;
                else nums[i]--;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

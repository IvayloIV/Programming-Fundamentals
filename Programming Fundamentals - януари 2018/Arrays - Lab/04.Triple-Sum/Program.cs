using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var isValid = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int q = i + 1; q < nums.Length; q++)
                {
                    if (nums.Any(a => a == nums[i] + nums[q]))
                    {
                        Console.WriteLine($"{nums[i]} + {nums[q]} == {nums[i] + nums[q]}");
                        isValid = true;
                    }
                }
            }
            if (!isValid)
            {
                Console.WriteLine("No");
            }
        }
    }
}

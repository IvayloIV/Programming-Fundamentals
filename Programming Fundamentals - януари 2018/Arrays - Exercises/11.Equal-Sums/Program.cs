using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                var leftPart = 0;
                var rightPart = 0;
                for (int left = 0; left < i; left++)
                {
                    leftPart += nums[left];
                }
                for (int right = i + 1; right < nums.Length; right++)
                {
                    rightPart += nums[right];
                }
                if (leftPart == rightPart)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}

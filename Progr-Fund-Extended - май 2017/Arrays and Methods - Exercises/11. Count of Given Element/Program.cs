using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Count_of_Given_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var currentNum = int.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (currentNum == nums[i])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

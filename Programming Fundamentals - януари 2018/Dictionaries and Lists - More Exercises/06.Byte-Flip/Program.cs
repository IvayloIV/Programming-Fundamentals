using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Where(a => a.Length == 2).ToList();
            for (int i = nums.Count() - 1; i >= 0; i--)
            {
                var currentWords = new string(nums[i].Reverse().ToArray());
                Console.Write((char)Convert.ToInt32(currentWords, 16));
            }
            Console.WriteLine();
        }
    }
}

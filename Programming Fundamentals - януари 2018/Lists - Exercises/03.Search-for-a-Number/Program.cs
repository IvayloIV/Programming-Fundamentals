using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var take = commands[0];
            var skip = commands[1];
            var neededN = commands[2];

            var newArr = new List<int>();
            for (int i = skip; i < take; i++)
            {
                newArr.Add(nums[i]);
            }
            if (newArr.Contains(neededN))
            {
                Console.WriteLine($"YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}

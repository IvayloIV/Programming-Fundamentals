using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int q = i + 1; q < arr.Length; q++)
                {
                    if (Math.Abs(arr[i] - arr[q]) == k)
                    {
                        count++;
                    }
                }               
            }
            Console.WriteLine(count);
        }
    }
}

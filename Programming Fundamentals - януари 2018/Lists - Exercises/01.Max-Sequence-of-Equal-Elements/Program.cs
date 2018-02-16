using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var prev = arr[0];
            var count = 1;
            var bestCount = 0;
            var bestNum = 0;
            for (int i = 1; i < arr.Count(); i++)
            {
                if (prev == arr[i])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (bestCount < count)
                {
                    bestCount = count;
                    bestNum = arr[i];
                }
                prev = arr[i];
            }
            if (count == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write(bestNum + " ");
            }
            Console.WriteLine();
        }
    }
}

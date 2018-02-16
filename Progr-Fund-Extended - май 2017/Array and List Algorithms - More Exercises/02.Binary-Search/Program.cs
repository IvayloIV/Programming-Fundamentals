using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            var linearCount = 0;
            var isFindNum = false;
            for (int i = 0; i < arr.Count; i++)
            {
                linearCount++;
                if (arr[i] == n)
                {
                    isFindNum = true;
                    break;
                }
            }
            var binaryCount = 1;
            arr.Sort();
            var middle = (arr.Count() - 1) / 2;
            while (arr.Count() > 1)
            {
                if (arr[middle] < n)
                {
                    arr = arr.Skip(middle + 1).ToList();
                }
                else if (arr[middle] > n)
                {
                    arr = arr.Take(middle).ToList();
                }
                else
                {
                    break;
                }
                middle = (arr.Count() - 1) / 2;
                binaryCount++;
            }
            if (isFindNum) Console.WriteLine($"Yes");
            else Console.WriteLine("No");
            Console.WriteLine($"Linear search made {linearCount} iterations");
            Console.WriteLine($"Binary search made {binaryCount} iterations");
        }
    }
}

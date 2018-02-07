using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var r = int.Parse(Console.ReadLine());
            var resultArr = new int[arr.Length];
            for (int i = 0; i < r; i++)
            {
                var lastNum = arr[arr.Length - 1];
                for (int q = arr.Length - 1; q >= 1; q--)
                {
                    arr[q] = arr[q - 1];
                }
                arr[0] = lastNum;
                for (int e = 0; e < resultArr.Length; e++)
                {
                    resultArr[e] += arr[e];
                }
            }
            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}

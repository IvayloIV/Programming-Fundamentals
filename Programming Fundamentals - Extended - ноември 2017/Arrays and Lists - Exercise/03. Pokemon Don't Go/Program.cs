using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long sum = 0;
            while (arr.Count != 0)
            {
                var n = int.Parse(Console.ReadLine());

                if (n >= 0 && n <= arr.Count - 1)
                {
                    sum += arr[n];
                    arr = RemovedMiddle(arr, n);
                }
                else if (n < 0)
                {
                    sum += arr[0];
                    arr = RemoveLeftPart(arr);
                }
                else if (n > arr.Count - 1)
                {
                    sum += arr[arr.Count - 1];
                    arr = RemovedRightPart(arr);
                }
            }
            Console.WriteLine(sum);
        }

        private static List<long> RemovedRightPart(List<long> arr)
        {
            var currentNumber = arr[arr.Count - 1];
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] <= currentNumber)
                {
                    arr[i] += currentNumber;
                }
                else
                {
                    arr[i] -= currentNumber;
                }
            }
            var currentArray = new List<long>();
            currentArray.AddRange(arr.Take(arr.Count - 1).ToList());
            currentArray.Add(arr[0]);
            arr = currentArray;
            return arr;
        }

        private static List<long> RemoveLeftPart(List<long> arr)
        {
            var currentNumber = arr[0];
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] <= currentNumber)
                {
                    arr[i] += currentNumber;
                }
                else
                {
                    arr[i] -= currentNumber;
                }
            }
            var currentArray = new List<long>();
            currentArray.Add(arr[arr.Count - 1]);
            currentArray.AddRange(arr.Skip(1).ToList());
            arr = currentArray;
            return arr;
        }

        private static List<long> RemovedMiddle(List<long> arr, int n)
        {
            var currentNumber = arr[n];
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] <= currentNumber)
                {
                    arr[i] += currentNumber;
                }
                else
                {
                    arr[i] -= currentNumber;
                }
            }
            var currentArray = arr.Take(n).ToList();
            currentArray.AddRange(arr.Skip(n + 1).ToList());
            arr = currentArray;
            return arr;
        }
    }
}

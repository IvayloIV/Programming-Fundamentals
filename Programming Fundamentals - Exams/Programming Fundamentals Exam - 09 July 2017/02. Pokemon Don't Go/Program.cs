using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long sum = 0;
            while (arr.Count() != 0)
            {
                var index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    index = 0;
                    var current = arr[index];
                    sum += current;
                    arr.RemoveAt(index);
                    arr = CreateNewArray(arr, current);
                    arr.Insert(0, arr[arr.Count() - 1]);
                }
                else if (index > arr.Count() - 1)
                {
                    index = arr.Count() - 1;
                    var current = arr[index];
                    sum += current;
                    arr.RemoveAt(index);
                    arr = CreateNewArray(arr, current);
                    arr.Add(arr[0]);
                }
                else
                {
                    var currentNum = arr[index];
                    sum += currentNum;
                    arr.RemoveAt(index);
                    arr = CreateNewArray(arr, currentNum);
                }
            }
            Console.WriteLine(sum);
        }

        private static List<long> CreateNewArray(List<long> arr, long currentNum)
        {
            var newBook = new List<long>();
            foreach (var num in arr)
            {
                if (num <= currentNum)
                {
                    newBook.Add(num + currentNum);
                }
                else
                {
                    newBook.Add(num - currentNum);
                }
            }
            return newBook;
        }
    }
}

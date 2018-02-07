using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var arr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            arr = ChangeArr(arr);
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static List<int> ChangeArr(List<int> arr)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputTokens[0] == "exchange")
                {
                    arr = Exchange(arr, inputTokens);
                }
                else if (inputTokens[0] == "max" || inputTokens[0] == "min")
                {
                    PrintMaxMin(arr, inputTokens);
                }
                else if (inputTokens[0] == "first" || inputTokens[0] == "last")
                {
                    PrintLastFirst(arr, inputTokens);
                }
            }
            return arr;
        }

        private static void PrintLastFirst(List<int> arr, string[] inputTokens)
        {
            var lastFirst = inputTokens[0];
            var count = int.Parse(inputTokens[1]);
            var oddEven = inputTokens[2];
            if (count < 0 || count > arr.Count())
            {
                Console.WriteLine($"Invalid count");
                return;
            }
            var newList = GetOddEven(arr, oddEven);         
            if (newList.Count() == 0)
            {
                Console.WriteLine($"[]");
                return;
            }
            newList = GetFirstLast(lastFirst, newList, count);
            
            Console.WriteLine($"[{string.Join(", ", newList)}]");
        }

        private static List<int> GetFirstLast(string lastFirst, List<int> newList, int count)
        {
            if (lastFirst == "first")
            {
                newList = newList.Take(count).ToList();
            }
            else if (lastFirst == "last")
            {
                newList.Reverse();
                newList = newList.Take(count).ToList();
                newList.Reverse();
            }
            return newList;
        }

        private static void PrintMaxMin(List<int> arr, string[] inputTokens)
        {
            var maxMin = inputTokens[0];
            var evenOdd = inputTokens[1];

            List<int> newList = GetOddEven(arr, evenOdd);
            
            if (newList.Count() == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            var num = GetMaxMin(newList, maxMin);
            
            var index = arr.LastIndexOf(num);
            Console.WriteLine(index);
        }

        private static int GetMaxMin(List<int> newList, string maxMin)
        {
            var num = 0;
            if (maxMin == "min")
            {
                num = newList.Min();
            }
            else if (maxMin == "max")
            {
                num = newList.Max();
            }
            return num;
        }

        private static List<int> GetOddEven(List<int> arr, string evenOdd)
        {
            var newList = new List<int>();
            if (evenOdd == "even")
            {
                newList = arr.Where(a => a % 2 == 0).ToList();
            }
            else if (evenOdd == "odd")
            {
                newList = arr.Where(a => a % 2 == 1).ToList();
            }
            return newList;
        }

        private static List<int> Exchange(List<int> arr, string[] inputTokens)
        {
            var index = int.Parse(inputTokens[1]);
            if (index < 0 || index > arr.Count() - 1)
            {
                Console.WriteLine($"Invalid index");
                return arr;
            }
            var leftPart = arr.Take(index + 1).ToList();
            var rightPart = arr.Skip(index + 1).ToList();
            return rightPart.Concat(leftPart).ToList();
        }
    }
}

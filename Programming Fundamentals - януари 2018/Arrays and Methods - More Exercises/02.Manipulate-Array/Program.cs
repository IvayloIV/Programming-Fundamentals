using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine();
                if (command == "Reverse")
                {
                    arr = ReverseArr(arr);
                }
                else if (command == "Distinct")
                {
                    arr = DistinctArr(arr);
                }
                else
                {
                    var commandTokens = command.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    arr = ReplaceArr(arr, int.Parse(commandTokens[1]), commandTokens[2]);
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }

        private static string[] ReplaceArr(string[] arr, int v1, string v2)
        {
            arr[v1] = v2;
            return arr;
        }

        private static string[] DistinctArr(string[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var currentElemen = arr[i];
                for (int q = i + 1; q < arr.Length; q++)
                {
                    if (currentElemen == arr[q])
                    {
                        arr[q] = "";
                    }
                }
            }
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    count++;
                }
            }
            var newArr = new string[count];
            var index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            return newArr;
        }

        private static string[] ReverseArr(string[] arr)
        {
            var newArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[arr.Length - 1 - i];
            }
            return newArr;
        }
    }
}

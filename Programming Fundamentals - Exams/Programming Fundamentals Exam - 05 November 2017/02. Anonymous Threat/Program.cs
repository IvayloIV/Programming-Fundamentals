using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonymous_Threat2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            List<string> arr = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                var startInput = Console.ReadLine();

                if (startInput == "3:1")
                {
                    break;
                }

                var input = startInput
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                arr = ChecksIfs(input, arr);
            }
            Console.WriteLine(string.Join(" ", arr));
        }

        private static List<string> ChecksIfs(string[] input, List<string> arr)
        {
            if (input[0] == "merge")
            {
                arr = MergeArr(arr, input);
            }
            else if (input[0] == "divide")
            {
                arr = DivideArr(arr, input);
            }
            return arr;
        }

        private static List<string> DivideArr(List<string> arr, string[] input)
        {
            var index = int.Parse(input[1]);
            var parts = int.Parse(input[2]);

            var getLenght = (int)Math.Floor((double)arr[index].Length / parts);

            List<string> newArr = AddAllParts(arr, index, parts, getLenght);

            return ConcatAllParts(newArr, arr, index);
        }

        private static List<string> ConcatAllParts(List<string> newArr, List<string> arr, int index)
        {
            var leftArr = arr.Take(index).ToList();
            leftArr.AddRange(newArr);
            var rightPart = arr.Skip(index + 1).ToList();
            return leftArr.Concat(rightPart).ToList();
        }

        private static List<string> AddAllParts(List<string> arr, int index, int parts, int getLenght)
        {
            var newArr = new List<string>();
            var text = arr[index];
            var skipLenght = 0;
            for (int i = 0; i < parts; i++)
            {
                if (i == parts - 1)
                {
                    newArr.Add(new string(text.Skip(skipLenght).ToArray()));
                }
                else
                {
                    newArr.Add(new string(text.Skip(skipLenght).Take(getLenght).ToArray()));
                }
                skipLenght += getLenght;
            }
            return newArr;
        }

        private static List<string> MergeArr(List<string> arr, string[] input)
        {
            var startIndex = int.Parse(input[1]);
            var endIndex = int.Parse(input[2]);

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex > arr.Count() - 1)
            {
                endIndex = arr.Count() - 1;
            }


            var middleArr = arr.Skip(startIndex).Take(endIndex - startIndex + 1).ToList();

            string middle = MakeMiddleArrToString(middleArr);

            return ConcatParts(startIndex, endIndex, middle, arr);
        }

        private static List<string> ConcatParts(int startIndex, int endIndex, string middle, List<string> arr)
        {
            var leftArr = arr.Take(startIndex).ToList();
            var rightArr = arr.Skip(endIndex + 1).ToList();
            leftArr.Add(middle);
            return leftArr.Concat(rightArr).ToList();
        }

        private static string MakeMiddleArrToString(List<string> middleArr)
        {
            var middle = "";
            foreach (var item in middleArr)
            {
                middle += item;
            }
            return middle;
        }
    }
}

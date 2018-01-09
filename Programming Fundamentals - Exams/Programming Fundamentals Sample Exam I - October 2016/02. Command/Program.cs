using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToList();

            arr = MakeChecks(arr);

            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static List<string> MakeChecks(List<string> arr)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var splitInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitInput[0] == "reverse")
                {
                    arr = ReverseAndSort(arr, splitInput);
                }
                else if (splitInput[0] == "sort")
                {
                    arr = ReverseAndSort(arr, splitInput);
                }
                else if (splitInput[0] == "rollLeft")
                {
                    arr = RollLeft(arr, splitInput);
                }
                else if (splitInput[0] == "rollRight")
                {
                    arr = RollRight(arr, splitInput);
                }
            }
            return arr;
        }

        private static List<string> RollRight(List<string> arr, string[] splitInput)
        {
            var count = int.Parse(splitInput[1]);
            bool ok = IsOkeysParam(splitInput, count);

            if (!ok)
            {
                return arr;
            }

            for (int i = 0; i < count % arr.Count(); i++)
            {
                var lastNum = arr[arr.Count() - 1];
                arr.RemoveAt(arr.Count() - 1);
                arr.Reverse();
                arr.Add(lastNum);
                arr.Reverse();
            }
            return arr;
        }

        private static bool IsOkeysParam(string[] splitInput, int count)
        {
            if (count < 0)
            {
                Console.WriteLine($"Invalid input parameters.");
                return false;
            }
            return true;
        }

        private static List<string> RollLeft(List<string> arr, string[] splitInput)
        {
            var count = int.Parse(splitInput[1]);
            bool ok = IsOkeysParam(splitInput, count);

            if (!ok)
            {
                return arr;
            }
            for (int i = 0; i < count % arr.Count(); i++)
            {
                var leftPart = arr.Take(1).ToList();
                var rightPart = arr.Skip(1).ToList();
                arr = rightPart.Concat(leftPart).ToList();
            }
            return arr;
        }

        private static List<string> ReverseAndSort(List<string> arr, string[] splitInput)
        {
            var start = int.Parse(splitInput[2]);
            var count = int.Parse(splitInput[4]);

            if (start < 0 || start > arr.Count() - 1 || start + count > arr.Count() || count < 0)
            {
                Console.WriteLine($"Invalid input parameters.");
                return arr;
            }

            var leftPart = arr.Take(start).ToList();
            var middlePart = arr.Skip(start).Take(count).ToList();
            if (splitInput[0] == "reverse")
            {
                middlePart.Reverse();
            }
            else
            {
                middlePart.Sort();
            }
            var rightPart = arr.Skip(start + count).ToList();
            leftPart = leftPart.Concat(middlePart).ToList();
            return leftPart.Concat(rightPart).ToList();
        }
    }
}

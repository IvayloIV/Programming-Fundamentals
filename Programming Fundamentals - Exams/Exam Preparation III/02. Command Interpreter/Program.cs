using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var currentInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currentInput[0] == "reverse")
                {
                    Reverse(arr, currentInput);
                }
                else if (currentInput[0] == "sort")
                {
                    Sort(arr, currentInput);
                }
                else if (currentInput[0] == "rollLeft")
                {
                    RollLeft(arr, currentInput);
                }
                else if (currentInput[0] == "rollRight")
                {
                    RollRight(arr, currentInput);
                }
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void RollRight(List<string> arr, string[] currentInput)
        {
            var count = int.Parse(currentInput[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            for (int i = 0; i < count % arr.Count(); i++)
            {
                var last = arr[arr.Count() - 1];
                arr.Reverse();
                arr.RemoveAt(0);
                arr.Add(last);
                arr.Reverse();
            }
        }

        private static void RollLeft(List<string> arr, string[] currentInput)
        {
            var count = int.Parse(currentInput[1]);

            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            for (int i = 0; i < count % arr.Count(); i++)
            {
                var first = arr[0];
                arr.RemoveAt(0);
                arr.Add(first);
            }
        }

        private static void Sort(List<string> arr, string[] currentInput)
        {
            var start = int.Parse(currentInput[2]);
            var count = int.Parse(currentInput[4]);

            if (start < 0 || count < 0 || (start + count) > arr.Count() || start > arr.Count - 1)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            var currentProblem = new List<string>();

            for (int i = start; i < start + count; i++)
            {
                currentProblem.Add(arr[i]);
            }
            currentProblem.Sort();
            var score = 0;
            for (int i = start; i < start + count; i++)
            {
                arr[i] = currentProblem[score];
                score++;
            }
        }

        private static void Reverse(List<string> arr, string[] currentInput)
        {
            var start = int.Parse(currentInput[2]);
            var count = int.Parse(currentInput[4]);

            if (start < 0 || count < 0 || (start + count) > arr.Count() || start > arr.Count - 1)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            var currentProblem = new List<string>();

            for (int i = start; i < start + count; i++)
            {
                currentProblem.Add(arr[i]);
            }
            currentProblem.Reverse();
            var score = 0;
            for (int i = start; i < start + count; i++)
            {
                arr[i] = currentProblem[score];
                score++;
            }
        }
    }
}

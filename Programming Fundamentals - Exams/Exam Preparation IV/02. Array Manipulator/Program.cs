using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                var currentCommand = command.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currentCommand[0] == "exchange")
                {
                    arr = Exchange(arr, currentCommand);
                }
                else if (currentCommand[0] == "max" || currentCommand[0] == "min")
                {
                    MaxMin(arr, currentCommand);
                }
                else if (currentCommand[0] == "first" || currentCommand[0] == "last")
                {
                    FirstLast(arr, currentCommand);
                }
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        private static void FirstLast(List<int> arr, string[] currentCommand)
        {
            var count = int.Parse(currentCommand[1]);
            if (count < 0 || count > arr.Count)
            {
                Console.WriteLine($"Invalid count");
                return;
            }

            var allEven = new List<int>();
            if (currentCommand[2] == "even")
            {
                allEven = arr.Where(a => a % 2 == 0).ToList();
            }
            else if (currentCommand[2] == "odd")
            {
                allEven = arr.Where(a => a % 2 == 1).ToList();
            }
            if (currentCommand[0] == "first")
            {
                allEven = allEven.Take(count).ToList();
                Console.WriteLine($"[{string.Join(", ", allEven.Take(count))}]");
            }
            else if (currentCommand[0] == "last")
            {
                allEven.Reverse();
                var allEvenLast = allEven.Take(count).ToList();
                allEvenLast.Reverse();
                Console.WriteLine($"[{string.Join(", ", allEvenLast)}]");
            }
        }


        private static void MaxMin(List<int> arr, string[] currentCommand)
        {
            if (currentCommand[0] == "max")
            {
                var number = new List<int>();
                if (currentCommand[1] == "odd")
                {
                    number = arr.Where(a => a % 2 == 1).ToList();
                }
                else if (currentCommand[1] == "even")
                {
                    number = arr.Where(a => a % 2 == 0).ToList();
                }
                if (number.Count == 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                var currentMaxOddNumber = number.Max();
                var index = arr.LastIndexOf(currentMaxOddNumber);
                Console.WriteLine($"{index}");
            }
            else if (currentCommand[0] == "min")
            {
                var number = new List<int>();
                if (currentCommand[1] == "odd")
                {
                    number = arr.Where(a => a % 2 == 1).ToList();
                }
                else if (currentCommand[1] == "even")
                {
                    number = arr.Where(a => a % 2 == 0).ToList();
                }
                if (number.Count == 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
                var currentMaxOddNumber = number.Min();
                var index = arr.LastIndexOf(currentMaxOddNumber);
                Console.WriteLine($"{index}");
            }
        }

        private static List<int> Exchange(List<int> arr, string[] currentCommand)
        {
            var index = int.Parse(currentCommand[1]);

            if (index < 0 || index > arr.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }

            var firstPart = arr.Take(index + 1).ToList();
            var lastPart = arr.Skip(index + 1).ToList();
            var contactTwoParcs = lastPart.Concat(firstPart).ToList();

            return contactTwoParcs;
        }
    }
}

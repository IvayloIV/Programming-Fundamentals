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
            var arrInt = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var splitInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                arrInt = MakeIfCheks(splitInput, arrInt);
            }
            Console.WriteLine($"[{string.Join(", ", arrInt)}]");
        }

        private static List<int> MakeIfCheks(List<string> splitInput, List<int> arrInt)
        {
            if (splitInput[0] == "exchange")
            {
                arrInt = Exchange(arrInt, int.Parse(splitInput[1]));
            }
            else if (splitInput[0] == "max" || splitInput[0] == "min")
            {
                MaxOrMin(arrInt, splitInput);
            }
            else if (splitInput[0] == "first" || splitInput[0] == "last")
            {
                FirstOrLast(arrInt, splitInput);
            }
            return arrInt;
        }

        private static void FirstOrLast(List<int> arrInt, List<string> splitInput)
        {
            if (int.Parse(splitInput[1]) > arrInt.Count())
            {
                Console.WriteLine($"Invalid count");
                return;
            }
            List<int> arrSplt = CurrentArrEvenOrOdd(arrInt, splitInput);
            arrInt = CurrentArrFirstLast(splitInput, arrSplt);
            
            Console.WriteLine($"[{string.Join(", ", arrInt)}]");
        }

        private static List<int> CurrentArrFirstLast(List<string> splitInput, List<int> arrSplt)
        {
            if (splitInput[0] == "first")
            {
                arrSplt = arrSplt.Take(int.Parse(splitInput[1])).ToList();
            }
            else if (splitInput[0] == "last")
            {
                arrSplt.Reverse();
                arrSplt = arrSplt.Take(int.Parse(splitInput[1])).ToList();
                arrSplt.Reverse();
            }
            return arrSplt;
        }

        private static List<int> CurrentArrEvenOrOdd(List<int> arrInt, List<string> splitInput)
        {
            if (splitInput[2] == "even")
            {
                return arrInt.Where(a => a % 2 == 0).ToList();
            }
            return arrInt.Where(a => a % 2 == 1).ToList();
        }

        private static void MaxOrMin(List<int> arrInt, List<string> splitInput)
        {
            var currentArr = arrInt;
            List<int> theNums = CurrentArrMinMax(splitInput, arrInt);

            if (theNums.Count() == 0)
            {
                Console.WriteLine($"No matches");
                return;
            }

            var index = currentArr.LastIndexOf(CurrentMaxMinNum(splitInput, theNums));
            Console.WriteLine($"{index}");
        }

        private static List<int> CurrentArrMinMax(List<string> splitInput, List<int> arrInt)
        {
            if (splitInput[1] == "odd")
            {
                return arrInt.Where(a => a % 2 == 1).ToList();
            }
            return arrInt.Where(a => a % 2 == 0).ToList();
        }

        private static int CurrentMaxMinNum(List<string> splitInput, List<int> theNums)
        {
            if (splitInput[0] == "max")
            {
                return theNums.Max();
            }
            return theNums.Min();
        }

        private static List<int> Exchange(List<int> arrInt, int v)
        {
            if (v < 0 || v > arrInt.Count() - 1)
            {
                Console.WriteLine("Invalid index");
                return arrInt;
            }

            var leftPart = arrInt.Take(v + 1).ToList();
            var rightPart = arrInt.Skip(v + 1).ToList();
            return rightPart.Concat(leftPart).ToList();
        }
    }
}

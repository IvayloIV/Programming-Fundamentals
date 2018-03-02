using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Trophon
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
          .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
          .Select(long.Parse)
          .ToList();

            var index = int.Parse(Console.ReadLine());

            var leftPart = arr.Take(index).ToList();
            var entryPoint = arr[index];
            var rightPart = arr.Skip(index + 1).ToList();

            var typeItems = Console.ReadLine();
            var typeOfPrice = Console.ReadLine();

            leftPart = ClaculateItemsAndPrice(leftPart, typeItems, entryPoint, typeOfPrice);
            rightPart = ClaculateItemsAndPrice(rightPart, typeItems, entryPoint, typeOfPrice);
            PrintResult(leftPart, rightPart);
        }

        private static void PrintResult(List<long> leftPart, List<long> rightPart)
        {
            if (leftPart.Sum() >= rightPart.Sum())
            {
                Console.WriteLine($"Left - {leftPart.Sum()}");
            }
            else
            {
                Console.WriteLine($"Right - {rightPart.Sum()}");
            }
        }

        private static List<long> ClaculateItemsAndPrice(List<long> v, string typeItems, long entryPoint, string typeOfPrice)
        {
            v = CalculateTypeItem(v, typeItems, entryPoint);
            v = CalculatePosOrNeg(v, typeOfPrice);
            return v;
        }

        private static List<long> CalculatePosOrNeg(List<long> part, string typeOfPrice)
        {
            if (typeOfPrice == "positive")
            {
                return part.Where(a => a > 0).ToList();
            }
            else if (typeOfPrice == "negative")
            {
                return part.Where(a => a < 0).ToList();
            }
            return part;
        }

        private static List<long> CalculateTypeItem(List<long> part, string typeItems, long entryPoint)
        {
            if (typeItems == "cheap")
            {
                return part.Where(a => a < entryPoint).ToList();
            }
            return part.Where(a => a >= entryPoint).ToList();
        }
    }
}

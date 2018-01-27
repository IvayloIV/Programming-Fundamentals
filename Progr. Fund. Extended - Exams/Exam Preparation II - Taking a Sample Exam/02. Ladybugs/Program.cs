using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrlength = int.Parse(Console.ReadLine());
            var lady = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var mainArr = new List<int>();
            for (int i = 0; i < arrlength; i++)
            {
                if (lady.Contains(i))
                {
                    mainArr.Add(1);
                }
                else
                {
                    mainArr.Add(0);
                }
            }

            MakeLoopPrintResult(mainArr);      
        }

        private static void MakeLoopPrintResult(List<int> mainArr)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var ladyIndex = int.Parse(inputTokens[0]);
                var direction = inputTokens[1];
                var flyLength = int.Parse(inputTokens[2]);

                if (ladyIndex < 0 || ladyIndex > mainArr.Count() - 1)
                {
                    continue;
                }
                if (mainArr[ladyIndex] == 0)
                {
                    continue;
                }

                if ((direction == "right" && flyLength > 0) || (direction == "left" && flyLength < 0))
                {
                    mainArr = LadyFly(mainArr, ladyIndex, flyLength, "right");
                }
                else if ((direction == "right" && flyLength < 0) || (direction == "left" && flyLength > 0))
                {
                    mainArr = LadyFly(mainArr, ladyIndex, flyLength, "left");
                }
            }
            Console.WriteLine(string.Join(" ", mainArr));
        }

        private static List<int> LadyFly(List<int> mainArr, int ladyIndex, int flyLength, string v)
        {
            flyLength = Math.Abs(flyLength);
            mainArr[ladyIndex] = 0;
            while (true)
            {
                if (v == "right")
                {
                    ladyIndex += flyLength;
                }
                else
                {
                    ladyIndex -= flyLength;
                }

                if (ladyIndex > mainArr.Count() - 1 || ladyIndex < 0)
                {
                    return mainArr;
                }
                if (mainArr[ladyIndex] == 0)
                {
                    mainArr[ladyIndex] = 1;
                    return mainArr;
                }
            }
        }
    }
}

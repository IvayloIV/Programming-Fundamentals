using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (inputTokens[0] == "decrease")
                {
                    arr = arr.Select(a => a = a - 1).ToList();
                }
                else if (inputTokens[0] == "swap")
                {
                    var firstIndex = int.Parse(inputTokens[1]);
                    var secondIndex = int.Parse(inputTokens[2]);
                    var firstNum = arr[firstIndex];
                    arr[firstIndex] = arr[secondIndex];
                    arr[secondIndex] = firstNum;
                }
                else if (inputTokens[0] == "multiply")
                {
                    var firstIndex = int.Parse(inputTokens[1]);
                    var secondIndex = int.Parse(inputTokens[2]);
                    long sum = arr[firstIndex] * arr[secondIndex];
                    arr[firstIndex] = sum;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}

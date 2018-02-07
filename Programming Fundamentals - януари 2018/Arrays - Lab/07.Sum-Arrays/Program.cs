using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var secondArr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < Math.Max(firstArr.Length, secondArr.Length); i++)
            {
                var firstNum = firstArr[i % firstArr.Length];
                var secondNum = secondArr[i % secondArr.Length];
                Console.Write($"{firstNum + secondNum} ");
            }
            Console.WriteLine();
        }
    }
}

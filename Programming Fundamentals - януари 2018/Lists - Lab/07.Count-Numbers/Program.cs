using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            arr.Sort();

            var prevNum = arr[0];
            var count = 1;
            for (int i = 1; i < arr.Count(); i++)
            {
                if (prevNum == arr[i])
                {
                    count++;
                }
                else
                {
                    PrintResult(prevNum, count);
                    count = 1;
                }
                prevNum = arr[i];
            }
            PrintResult(prevNum, count);
        }

        private static void PrintResult(int prevNum, int count)
        {
            Console.WriteLine($"{prevNum} -> {count}");
        }
    }
}

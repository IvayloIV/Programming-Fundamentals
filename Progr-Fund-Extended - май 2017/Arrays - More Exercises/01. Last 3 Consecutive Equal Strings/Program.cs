using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var prev = arr[0];
            var count = 1;
            var bestWord = "";

            for (int i = 1; i < arr.Length; i++)
            {
                if (prev == arr[i])
                {
                    count++;
                    if (count == 3)
                    {
                        bestWord = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }
                prev = arr[i];
            }
            Console.WriteLine($"{bestWord} {bestWord} {bestWord}");
        }
    }
}

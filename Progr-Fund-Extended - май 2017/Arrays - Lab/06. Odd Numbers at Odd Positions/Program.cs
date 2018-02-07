using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInts = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < arrInts.Length; i++)
            {
                var currentNum = Math.Abs(arrInts[i]);
                if (currentNum % 2 == 1 && i % 2 == 1)
                {
                    Console.WriteLine($"Index {i} -> {arrInts[i]}");
                }
            }
        }
    }
}

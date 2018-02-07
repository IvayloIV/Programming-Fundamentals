using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInts = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var count = 0;
            for (int i = 0; i < arrInts.Length; i++)
            {
                var currentNum = Math.Abs(arrInts[i]);
                if (currentNum % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

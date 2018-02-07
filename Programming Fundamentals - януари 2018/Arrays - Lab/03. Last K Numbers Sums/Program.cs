using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            long[] arr = new long[n];
            arr[0] = 1;
            var k = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                long currentNum = 0;
                for (int q = Math.Max(0, i - k); q < i; q++)
                {
                    currentNum += arr[q];
                }
                arr[i] = currentNum;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

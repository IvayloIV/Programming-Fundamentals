using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var squnt = 1;
            var maxSquntCount = 1;
            var num = 0;
            var prev = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != prev)
                {
                    squnt = 1;
                }
                else
                {
                    squnt++;
                }
                if (squnt > maxSquntCount)
                {
                    num = arr[i];
                    maxSquntCount = squnt;
                }
                prev = arr[i];
            }
            PrintResult(num, maxSquntCount);
        }

        private static void PrintResult(int num, int maxSquntCount)
        {
            for (int i = 0; i < maxSquntCount; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

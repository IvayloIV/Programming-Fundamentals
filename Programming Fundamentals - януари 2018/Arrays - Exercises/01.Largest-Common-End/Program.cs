using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var arr2 = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var equalLeft = 0;
            var equalRight = 0;
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    equalLeft++;
                }
                if (arr1.Length - 1 - i < 0 || arr2.Length - 1 - i < 0)
                {
                    continue;
                }
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    equalRight++;
                }
            }

            if (equalLeft > equalRight)
            {
                Console.WriteLine(equalLeft);
            }
            else if (equalLeft < equalRight)
            {
                Console.WriteLine(equalRight);
            }
            else if (equalRight == 0 && equalLeft == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(equalLeft);
            }
        }
    }
}

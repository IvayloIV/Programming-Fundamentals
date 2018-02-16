using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sort_Array_Using_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var temp = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                var count = 0;
                for (int q = i - 1; q >= 0; q--)
                {
                    if (arr[i - count] < arr[q])
                    {
                        temp = arr[q];
                        arr[q] = arr[i - count];
                        arr[i - count] = temp;
                        count++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

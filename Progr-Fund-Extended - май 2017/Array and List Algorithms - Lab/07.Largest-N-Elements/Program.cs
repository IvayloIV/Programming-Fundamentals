using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            var temp = 0;

            var outputArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int q = arr.Length - 1; q >= 1 + i; q--)
                {
                    if (arr[q] > arr[q - 1])
                    {
                        temp = arr[q];
                        arr[q] = arr[q - 1];
                        arr[q - 1] = temp;
                    }
                }
                outputArr.Add(arr[i]);
            }
            Console.WriteLine(string.Join(" ", outputArr.Take(n)));
        }
    }
}

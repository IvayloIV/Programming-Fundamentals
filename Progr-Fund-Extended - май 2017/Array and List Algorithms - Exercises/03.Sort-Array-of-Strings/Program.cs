using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();
            var temp = "";
            for (int i = 0; i < arr.Length; i++)
            {
                for (int q = 1; q < arr.Length - i; q++)
                {
                    if (arr[q].CompareTo(arr[q - 1]) == -1)
                    {
                        temp = arr[q];
                        arr[q] = arr[q - 1];
                        arr[q - 1] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

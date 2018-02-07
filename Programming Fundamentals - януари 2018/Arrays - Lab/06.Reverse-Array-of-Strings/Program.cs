using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var firstNum = arr[i];
                var lastNum = arr[arr.Length - i - 1];
                arr[i] = lastNum;
                arr[arr.Length - i - 1] = firstNum;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

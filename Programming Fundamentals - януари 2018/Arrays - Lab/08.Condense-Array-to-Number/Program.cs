using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            while (arr.Length > 1)
            {
                var newArr = new int[arr.Length - 1];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    newArr[i] = arr[i] + arr[i + 1];
                }
                arr = newArr;
            }
            Console.WriteLine(arr[0]);
        }
    }
}

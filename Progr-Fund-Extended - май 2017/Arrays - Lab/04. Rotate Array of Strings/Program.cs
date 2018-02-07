using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrStr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var lastElement = arrStr[arrStr.Length - 1];
            for (int i = arrStr.Length - 1; i >= 1; i--)
            {
                arrStr[i] = arrStr[i - 1];
            }
            arrStr[0] = lastElement;
            for (int i = 0; i < arrStr.Length; i++)
            {
                Console.Write(arrStr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

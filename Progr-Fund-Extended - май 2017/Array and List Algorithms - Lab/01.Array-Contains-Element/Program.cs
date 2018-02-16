using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var m = int.Parse(Console.ReadLine());
            var isFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == m)
                {
                    isFound = true;
                }
            }
            var result = isFound ? "yes" : "no";
            Console.WriteLine(result);
        }
    }
}

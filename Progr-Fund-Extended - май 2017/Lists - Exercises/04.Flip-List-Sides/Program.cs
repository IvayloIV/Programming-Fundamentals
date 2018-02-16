using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToList();

            for (int i = 1; i < arr.Count() / 2; i++)
            {
                var leftElement = arr[i];
                arr[i] = arr[arr.Count() - 1 - i];
                arr[arr.Count() - 1 - i] = leftElement;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

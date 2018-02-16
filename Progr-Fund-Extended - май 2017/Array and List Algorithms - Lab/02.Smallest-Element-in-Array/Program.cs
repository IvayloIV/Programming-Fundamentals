using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var smallerNum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (smallerNum > arr[i])
                {
                    smallerNum = arr[i];
                }
            }
            Console.WriteLine(smallerNum);
        }
    }
}

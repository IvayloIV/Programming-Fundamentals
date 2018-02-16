using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToList();
            var newArr = new List<string>();
            for (int i = 1; i < arr.Count; i += 2)
            {
                newArr.Add(arr[i]);
            }
            Console.WriteLine(string.Join("", newArr));
        }
    }
}

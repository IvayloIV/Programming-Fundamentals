using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split('|').ToArray();
            var outputArr = new List<string>();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                outputArr.Add(arr[i].Trim());
            }
            Console.WriteLine(string.Join(" ", outputArr));
        }
    }
}

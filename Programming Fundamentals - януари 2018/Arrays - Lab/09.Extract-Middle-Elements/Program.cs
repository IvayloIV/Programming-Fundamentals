using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine("{ " + arr[0] + " }");
            }
            else if (arr.Length % 2 == 0)
            {
                var middle = arr.Length / 2 - 1;
                Console.WriteLine("{ " + arr[middle] + ", " + arr[middle + 1] + " }");
            }
            else if (arr.Length % 2 == 1)
            {
                var middleN = arr.Length / 2;
                Console.WriteLine("{ " + arr[middleN - 1] + ", " + arr[middleN] + ", " + arr[middleN + 1] + " }");
            }
        }
    }
}

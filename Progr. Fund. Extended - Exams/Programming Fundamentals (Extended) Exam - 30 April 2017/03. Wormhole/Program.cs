using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0) {
                    var index = i;
                    i = arr[i];
                    arr[index] = 0;                 
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

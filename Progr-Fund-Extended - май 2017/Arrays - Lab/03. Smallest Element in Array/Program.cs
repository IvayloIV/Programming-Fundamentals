using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInts = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var minN = int.MaxValue;
            for (int i = 0; i < arrInts.Length; i++)
            {
                if (arrInts[i] < minN) {
                    minN = arrInts[i];
                }
            }
            Console.WriteLine(minN);
        }
    }
}

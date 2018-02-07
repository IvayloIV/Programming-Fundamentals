using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Equal_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var allNums = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var prevNum = allNums[0];
            for (int i = 1; i < allNums.Length; i++)
            {
                if (prevNum != allNums[i])
                {
                    Console.WriteLine("No");
                    return;
                }
                prevNum = allNums[i];
            }
            Console.WriteLine("Yes");
        }
    }
}

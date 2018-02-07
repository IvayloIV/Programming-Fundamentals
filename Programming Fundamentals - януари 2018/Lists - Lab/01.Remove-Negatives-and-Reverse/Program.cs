using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var arrOutput = new List<int>();
            var isAnyIsPossitive = false;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] >= 0)
                {
                    arrOutput.Add(arr[i]);
                    isAnyIsPossitive = true;
                }
            }
            if (isAnyIsPossitive)
            {
                Console.WriteLine(string.Join(" ", arrOutput));
            }
            else
            {
                Console.WriteLine($"empty");
            }
        }
    }
}

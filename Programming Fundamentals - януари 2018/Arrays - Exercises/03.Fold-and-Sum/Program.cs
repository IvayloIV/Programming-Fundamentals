using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInt = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var countN = arrInt.Length / 4;
            var firstArr = new int[countN * 2];
            var secoundArr = new int[countN * 2];
            for (int i = 0; i < countN; i++)
            {
                firstArr[countN - i - 1] = arrInt[i];
                firstArr[i + countN] = arrInt[arrInt.Length - 1 - i];
            }
            var index = 0;
            for (int i = 0; i < countN * 2; i++)
            {
                secoundArr[index] = arrInt[i + countN];
                index++;
            }
            var sumArr = new int[countN * 2];
            for (int i = 0; i < firstArr.Length; i++)
            {
                sumArr[i] = firstArr[i] + secoundArr[i];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}

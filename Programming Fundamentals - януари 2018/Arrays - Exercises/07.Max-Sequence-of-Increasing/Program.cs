using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var squnt = 1;
            var maxSquntCount = 1;
            var numIndex = 0;
            var prev = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] <= prev)
                {
                    squnt = 1;
                }
                else
                {
                    squnt++;
                }
                if (squnt > maxSquntCount)
                {
                    numIndex = i;
                    maxSquntCount = squnt;
                }
                prev = arr[i];
            }
            var resultArr = new int[maxSquntCount];
            var index = 0;
            for (int i = numIndex; i > numIndex - maxSquntCount; i--)
            {
                resultArr[resultArr.Length - 1 - index] = arr[i];
                index++;
            }
            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}

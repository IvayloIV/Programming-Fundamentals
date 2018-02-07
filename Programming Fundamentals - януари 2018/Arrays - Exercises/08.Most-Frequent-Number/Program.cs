using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var mostRepeat = 0;
            var maxN = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                var currentRepeat = 1;
                for (int q = 0; q < arr.Length; q++)
                {
                    if (q == i)
                    {
                        continue;
                    }
                    if (arr[i] == arr[q])
                    {
                        currentRepeat++;
                    }
                }
                if (mostRepeat < currentRepeat)
                {
                    mostRepeat = currentRepeat;
                    maxN = arr[i];
                }
            }
            Console.WriteLine(maxN);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var arrCount = new List<int>();
            var arrWords = new List<string>();
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arrWords.Contains(arr[i]))
                {
                    continue;
                }
                var currentWord = arr[i];
                var count = 1;
                for (int q = 0; q < arr.Count(); q++)
                {
                    if (q == i)
                    {
                        continue;
                    }
                    if (arr[q] == currentWord)
                    {
                        count++;
                    }
                }
                arrWords.Add(currentWord);
                arrCount.Add(count);
            }
            var maxN = arrCount.Max();
            while (maxN != 0)
            {               
                var index = arrCount.IndexOf(maxN);
                double pros = ((double)maxN / arr.Count()) * 100d;
                Console.WriteLine($"{arrWords[index]} -> {maxN} times ({(pros):f2}%)");
                arrCount[index] = 0;
                maxN = arrCount.Max();
            }
        }
    }
}

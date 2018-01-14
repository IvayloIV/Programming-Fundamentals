using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var lastItem = arr[arr.Count() - 1];
            arr.RemoveAt(arr.Count() - 1);

            var startArr = arr;
            var steps = 0;
            var indexDonald = 0;
            while (true)
            {
                if (steps != 0)
                {
                    indexDonald = int.Parse(Console.ReadLine());
                }

                arr = arr.Select(a => a - 1).ToList();


                if (arr[steps == 0 ? lastItem : indexDonald] == 0)
                {
                    Console.WriteLine(string.Join(" ", arr));
                    Console.WriteLine(steps);
                    return;
                }


                for (int i = 0; i < arr.Count(); i++)
                {
                    if (arr[i] == 0)
                    {
                        arr[i] = startArr[i];
                    }
                }

                steps++;
            }
        }
    }
}

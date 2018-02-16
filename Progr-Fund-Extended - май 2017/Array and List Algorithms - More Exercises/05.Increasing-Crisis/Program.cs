using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Increasing_Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mainArr = new List<int>();

            for (int t = 0; t < n; t++)
            {
                var newArr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                if (mainArr.Count == 0)
                {
                    mainArr.AddRange(newArr);
                }
                else
                {
                    for (int i = mainArr.Count() - 1; i >= 0; i--)
                    {
                        if (mainArr[i] <= newArr[0])
                        {
                            mainArr.Insert(i + 1, newArr[0]);
                            for (int q = 1; q < newArr.Count(); q++)
                            {
                                mainArr.Insert(i + q + 1, newArr[q]);
                                if (q + i + 2 <= mainArr.Count() - 1 && mainArr[q + i + 1] > mainArr[q + i + 2])
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                for (int i = 0; i < mainArr.Count() - 1; i++)
                {
                    if (mainArr[i] > mainArr[i + 1])
                    {
                        mainArr = mainArr.Take(i + 1).ToList();
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", mainArr));
        }
    }
}

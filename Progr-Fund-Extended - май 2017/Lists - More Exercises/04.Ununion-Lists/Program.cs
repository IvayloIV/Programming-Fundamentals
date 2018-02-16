using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainArr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine().Split().Select(int.Parse).Distinct().ToList();
                foreach (var item in arr)
                {
                    if (mainArr.Contains(item))
                    {
                        mainArr.RemoveAll(a => a == item);
                    }
                    else
                    {
                        mainArr.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", mainArr.OrderBy(a => a)));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int>();
            var lastShot = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                if (input == "bang")
                {
                    if (arr.Count() == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShot}");
                        return;
                    }
                    double average = arr.Average();
                    var helperArr = arr.Where(a => a <= average).ToList();
                    if (helperArr.Count() == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastShot}");
                        return;
                    }
                    else
                    {
                        lastShot = helperArr[0];
                        arr.Remove(lastShot);
                        Console.WriteLine($"shot {lastShot}");
                        arr = arr.Select(a => a -= 1).ToList();
                    }
                    continue;
                }
                var num = int.Parse(input);
                arr.Insert(0, num);
            }
            if (arr.Count() == 0)
            {
                Console.WriteLine($"you shot them all. last one was {lastShot}");
            }
            else
            {
                Console.WriteLine($"survivors: {string.Join(" ", arr)}");
            }
        }
    }
}

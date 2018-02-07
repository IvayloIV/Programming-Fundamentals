using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var day = 0;
            var seasons = 0;
            var allDays = 1;
            while (true)
            {
                if (day > arr.Length - 1)
                {
                    day = 0;
                    seasons++;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] != 0)
                        {
                            arr[i]++;
                        }
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (day != i)
                    {
                        if (arr[i] != 0)
                        {
                            arr[i]--;
                        }
                    }
                }
                if (arr.All(a => a == 0))
                {
                    break;
                }
                day++;
                allDays++;              
            }
            Console.WriteLine($"survived {allDays} days ({seasons} seasons)");
        }
    }
}

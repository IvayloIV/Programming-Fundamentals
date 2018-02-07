using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
            var height = double.Parse(arr[0]);

            for (int i = 1; i < arr.Length; i += 2)
            {
                var type = arr[i];
                var steps = double.Parse(arr[i + 1]);
                if (type == "up")
                {
                    height += steps;
                }
                else if (type == "down")
                {
                    height -= steps;
                }
                if (height <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }
            Console.WriteLine($"got through safely. current altitude: {height}m");
        }
    }
}

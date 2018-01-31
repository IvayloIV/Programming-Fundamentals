using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float secound = float.Parse(Console.ReadLine());

            float allSeconds = (hours * 3600) + (minutes * 60) + secound;

            Console.WriteLine(meters / allSeconds);
            Console.WriteLine((meters / 1000) / (allSeconds / 3600));
            Console.WriteLine((meters / 1609) / (allSeconds / 3600));
        }
    }
}

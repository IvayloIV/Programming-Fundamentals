using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var capacity = 0;
            for (int i = 0; i < n; i++)
            {
                var liters = int.Parse(Console.ReadLine());
                if (capacity + liters <= 255)
                {
                    capacity += liters;
                }
                else
                {
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);
        }
    }
}

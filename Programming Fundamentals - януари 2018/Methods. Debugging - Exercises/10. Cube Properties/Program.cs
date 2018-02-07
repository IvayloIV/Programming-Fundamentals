using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            if (type == "face")
            {
                PrintFace(n);
            }
            else if (type == "space")
            {
                PrintSpace(n);
            }
            else if (type == "volume")
            {
                PrintVolume(n);
            }
            else if (type == "area")
            {
                PrintArea(n);
            }
        }

        private static void PrintArea(double n)
        {
            Console.WriteLine($"{(6 * n * n):f2}");
        }

        private static void PrintVolume(double n)
        {
            Console.WriteLine($"{(n * n * n):f2}");
        }

        private static void PrintSpace(double n)
        {
            Console.WriteLine($"{(Math.Sqrt(3 * n * n)):f2}");
        }

        private static void PrintFace(double n)
        {
            Console.WriteLine($"{(Math.Sqrt(2 * n * n)):f2}");
        }
    }
}

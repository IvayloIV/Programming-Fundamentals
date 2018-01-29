using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, weight, height = 0;
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());
            height = (lenght * weight * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", height);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Calculate_Trian
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var result = CalculateArea(width, height);
            Console.WriteLine(result);
        }

        private static object CalculateArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}

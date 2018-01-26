using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberPhoto = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var sizeInBytes = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{numberPhoto:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:d2}");
            if (sizeInBytes <= 999)
            {
                Console.WriteLine($"Size: {sizeInBytes}B");
            }
            else if (sizeInBytes <= 999999)
            {
                Console.WriteLine($"Size: {sizeInBytes / 1000}KB");
            }
            else
            {
                Console.WriteLine($"Size: {sizeInBytes / 1000000}MB");
            }

            if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
        }
    }
}

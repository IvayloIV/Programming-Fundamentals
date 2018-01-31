using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersOfPictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = long.Parse(Console.ReadLine());
            var amountTime = long.Parse(Console.ReadLine());

            var usefull = Math.Ceiling(numbersOfPictures * (filterFactor / 100D));
            var totalPictures = filterTime * numbersOfPictures;
            var sumOfPictures = usefull * amountTime;
            var totalTime = totalPictures + sumOfPictures;
            var time = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine($"{time.Days}:{time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");
        }
    }
}

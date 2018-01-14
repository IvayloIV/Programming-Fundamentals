using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var pictures = double.Parse(Console.ReadLine());
            var filterTime = double.Parse(Console.ReadLine());
            var uploadTime = double.Parse(Console.ReadLine());
            var uploadPictures = double.Parse(Console.ReadLine());

            MakeCalculations(pictures, filterTime, uploadTime, uploadPictures);
        }

        private static void MakeCalculations(double pictures, double filterTime, double uploadTime, double uploadPictures)
        {
            double filteredPictures = Math.Ceiling(pictures * ((double)uploadTime / 100));
            double totalPictures = pictures * filterTime;
            double filteredPict = filteredPictures * uploadPictures;
            double totalTime = totalPictures + filteredPict;
            var date = TimeSpan.FromSeconds(totalTime);
            PrintResult(date);
        }

        private static void PrintResult(TimeSpan date)
        {
            Console.WriteLine($"{date.Days}:{date.Hours:d2}:{date.Minutes:d2}:{date.Seconds:d2}");
        }
    }
}

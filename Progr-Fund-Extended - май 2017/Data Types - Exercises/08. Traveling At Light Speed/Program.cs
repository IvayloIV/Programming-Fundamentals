using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearsL = decimal.Parse(Console.ReadLine());

            var lightYear = 9450000000000M;
            var speedLight = 300000M;

            var totalSum = (lightYear / speedLight) * yearsL;
            var time = TimeSpan.FromSeconds((double)totalSum);

            Console.WriteLine($"{(time.Days / 7):f0} weeks\r\n{(time.Days % 7):f0} days\r\n{(time.Hours):f0} hours" +
                $"\r\n{(time.Minutes):f0} minutes\r\n{time.Seconds} seconds");
        }
    }
}

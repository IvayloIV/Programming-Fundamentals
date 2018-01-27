using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Time_Since_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = int.Parse(Console.ReadLine());

            var days = year * 365;
            var hours = days * 24;
            var minutes = hours * 60;
            Console.WriteLine($"{year} years = {days} days = {hours} hours = {minutes} minutes.");
        }
    }
}

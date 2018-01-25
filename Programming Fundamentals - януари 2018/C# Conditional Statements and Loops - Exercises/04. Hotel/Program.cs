using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightCount = int.Parse(Console.ReadLine());

            double studio = 0;
            double doubleD = 0;
            double suite = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                doubleD = 65;
                suite = 75;
            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                doubleD = 72;
                suite = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                doubleD = 77;
                suite = 89;
            }

           
            if ((month == "May" || month == "October") && nightCount > 7)
            {
                studio *= 0.95;
            }
            if ((month == "June" || month == "September") && nightCount > 14)
            {
                doubleD *= 0.9;
            }
            if ((month == "July" || month == "August" || month == "December") && nightCount > 14)
            {
                suite *= 0.85;
            }
            double freeStudio = studio;
            studio *= nightCount;
            doubleD *= nightCount;
            suite *= nightCount;
            if ((month == "September" || month == "October") && nightCount > 7)
            {
                studio -= freeStudio;
            }
            Console.WriteLine($"Studio: {studio:f2} lv.");
            Console.WriteLine($"Double: {doubleD:f2} lv.");
            Console.WriteLine($"Suite: {suite:f2} lv.");
        }
    }
}

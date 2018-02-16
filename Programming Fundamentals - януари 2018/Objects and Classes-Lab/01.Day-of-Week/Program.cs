using System;
using System.Globalization;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            var parsedData = DateTime.ParseExact(data, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(parsedData.DayOfWeek);
        }
    }
}

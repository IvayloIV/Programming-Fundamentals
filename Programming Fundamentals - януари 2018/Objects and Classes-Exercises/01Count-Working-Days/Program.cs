using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var holidays = new List<DateTime>
            {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26),
            };
            var workDays = 0;
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                var currentDay = i.DayOfWeek.ToString();
                var currentData = new DateTime(4, i.Month, i.Day);
                if (currentDay == "Saturday" || currentDay == "Sunday" || holidays.Contains(currentData))
                {
                    continue;
                }
                workDays++;
            }
            Console.WriteLine(workDays);
        }
    }
}

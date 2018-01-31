using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            int year = centures * 100;
            int days = (int)Math.Floor(year * 365.2422);
            long hours = (long)days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            Console.WriteLine($"{centures} centuries = {year} years = {days} days = {hours} " +
                $"hours = {minutes} minutes = {seconds} seconds = {seconds}000 " +
                $"milliseconds = {seconds}000000 microseconds = {seconds}000000000 nanoseconds");
        }
    }
}

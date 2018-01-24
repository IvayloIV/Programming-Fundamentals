using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());

            if (age >= 0 && age <= 18)
            {
                if (day == "weekday")
                {
                    Console.WriteLine($"12$");
                }
                else if (day == "weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (day == "holiday")
                {
                    Console.WriteLine("5$");
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (day == "weekday")
                {
                    Console.WriteLine($"18$");
                }
                else if (day == "weekend")
                {
                    Console.WriteLine("20$");
                }
                else if (day == "holiday")
                {
                    Console.WriteLine("12$");
                }
            }
            else if (age > 64 && age <= 122)
            {
                if (day == "weekday")
                {
                    Console.WriteLine($"12$");
                }
                else if (day == "weekend")
                {
                    Console.WriteLine("15$");
                }
                else if (day == "holiday")
                {
                    Console.WriteLine("10$");
                }
            }
            else {
                Console.WriteLine("Error!");
            }
        }
    }
}

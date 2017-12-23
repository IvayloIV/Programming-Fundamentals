using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                var price = decimal.Parse(Console.ReadLine());
                var date = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
                var capsules = int.Parse(Console.ReadLine());

                int daysInMon = DateTime.DaysInMonth(date[2], date[1]);
                var orderPirce = daysInMon * price * capsules;
                totalPrice += orderPirce;
                Console.WriteLine($"The price for the coffee is: ${orderPirce:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

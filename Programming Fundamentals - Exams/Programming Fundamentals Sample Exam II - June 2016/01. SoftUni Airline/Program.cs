using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal totalSum = 0;
            for (int i = 0; i < n; i++)
            {
                var adultPassengersCount = decimal.Parse(Console.ReadLine());
                var adultTicketPrice = decimal.Parse(Console.ReadLine());
                var youthPasssengersCount = decimal.Parse(Console.ReadLine());
                var youthTicketPrice = decimal.Parse(Console.ReadLine());
                var fuelPrice = decimal.Parse(Console.ReadLine());
                var fuelConsumption = decimal.Parse(Console.ReadLine());
                var flightDuration = decimal.Parse(Console.ReadLine());

                var adultYouth = (adultPassengersCount * adultTicketPrice) + (youthPasssengersCount * youthTicketPrice);
                var fuel = fuelPrice * fuelConsumption * flightDuration;
                var sum = adultYouth - fuel;
                if (sum >= 0)
                {
                    Console.WriteLine($"You are ahead with {sum:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {sum:f3}$.");
              }
                totalSum += sum;
            }
            Console.WriteLine($"Overall profit -> {totalSum:f3}$.");
            Console.WriteLine($"Average profit -> {(totalSum / n):f3}$.");
        }
    }
}

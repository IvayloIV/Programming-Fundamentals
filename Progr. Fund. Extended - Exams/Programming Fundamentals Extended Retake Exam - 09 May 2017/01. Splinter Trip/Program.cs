using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripDistance = double.Parse(Console.ReadLine());
            var fuelTankCapacity = double.Parse(Console.ReadLine());
            var heavyWingsMiles = double.Parse(Console.ReadLine());

            var nonHeavyMils = tripDistance - heavyWingsMiles;
            var nonHeavyConsume = nonHeavyMils * 25;
            var heavyWingsConsume = heavyWingsMiles * (25D * 1.5);
            var fuelConsume = nonHeavyConsume + heavyWingsConsume;
            var totalFuelConsume = fuelConsume * 1.05;
            PrintResult(totalFuelConsume, fuelTankCapacity);            
        }

        private static void PrintResult(double totalFuelConsume, double fuelTankCapacity)
        {
            Console.WriteLine($"Fuel needed: {totalFuelConsume:f2}L");

            if (fuelTankCapacity >= totalFuelConsume)
            {
                Console.WriteLine($"Enough with {(fuelTankCapacity - totalFuelConsume):f2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {(totalFuelConsume - fuelTankCapacity):f2}L more fuel.");
            }
        }
    }
}

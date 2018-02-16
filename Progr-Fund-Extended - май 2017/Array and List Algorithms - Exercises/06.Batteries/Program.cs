using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var batteres = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var powers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            var hours = int.Parse(Console.ReadLine());

            for (int i = 0; i < batteres.Count(); i++)
            {
                var currentBattery = batteres[i];
                var currentPower = powers[i];
                var neededHours = currentPower * hours;
                var diff = currentBattery - neededHours;
                if (diff < 0)
                {
                    var lasttedHours = Math.Ceiling(currentBattery / currentPower);
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {lasttedHours} hours)");
                }
                else
                {
                    var pross = (diff / currentBattery) * 100d;
                    Console.WriteLine($"Battery {i + 1}: {diff:f2} mAh ({pross:f2})%");
                }
            }
        }
    }
}

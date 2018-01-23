using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            var energyKal = (volume * energy) / 100D;
            var sugarG = (volume * sugar) / 100D;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyKal}kcal, {sugarG}g sugars");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Character
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var minHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var minEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', minHealth)}{new string('.', maxHealth - minHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', minEnergy)}{new string('.', maxEnergy - minEnergy)}|");
        }
    }
}

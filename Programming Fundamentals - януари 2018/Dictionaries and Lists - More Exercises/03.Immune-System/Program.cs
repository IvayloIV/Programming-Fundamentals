using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxHelth = int.Parse(Console.ReadLine());
            var initial = maxHelth;
            var defeatedViruses = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var virusStrenght = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    virusStrenght += input[i];
                }
                virusStrenght /= 3;
                var ascii = virusStrenght;
                virusStrenght *= input.Length;
                if (defeatedViruses.Contains(input))
                {
                    virusStrenght /= 3;
                }
                maxHelth -= virusStrenght;
                Console.WriteLine($"Virus {input}: {ascii} => {virusStrenght} seconds");
                if (maxHelth <= 0)
                {
                    Console.WriteLine($"Immune System Defeated.");
                    return;
                }
                Console.WriteLine($"{input} defeated in {(virusStrenght % 3600) / 60}m {virusStrenght % 60}s.");
                Console.WriteLine($"Remaining health: {maxHelth}");
                maxHelth = (int)(maxHelth * 1.2);
                if (maxHelth > initial) maxHelth = initial;
                defeatedViruses.Add(input);
            }
            Console.WriteLine($"Final Health: {maxHelth}");
        }
    }
}

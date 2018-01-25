using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Bake!") {
                    break;
                }

                Console.WriteLine($"Adding ingredient {input}.");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}

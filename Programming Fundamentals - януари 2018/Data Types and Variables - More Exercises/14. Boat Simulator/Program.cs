using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firtsBoat = char.Parse(Console.ReadLine());
            var secondBoat = char.Parse(Console.ReadLine());

            var n = int.Parse(Console.ReadLine());

            var firstResult = 0;
            var secondResult = 0;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                if (input == "UPGRADE")
                {
                    firtsBoat = (char)(firtsBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        firstResult += input.Length;
                    }
                    else
                    {
                        secondResult += input.Length;
                    }
                }
                if (firstResult >= 50)
                {
                    Console.WriteLine(firtsBoat);
                    return;
                }
                else if (secondResult >= 50)
                {
                    Console.WriteLine(secondBoat);
                    return;
                }
            }
            if (firstResult > secondBoat)
            {
                Console.WriteLine(firtsBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}

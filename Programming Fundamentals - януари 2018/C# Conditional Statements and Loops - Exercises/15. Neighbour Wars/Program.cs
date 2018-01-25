using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var healthPesho = 100;
            var healthGosho = 100;

            var round = 0;
            while (true)
            {
                round++;
                if (round % 2 == 1)
                {
                    healthGosho -= peshoDamage;
                    if (healthGosho > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                    }
                }
                else
                {
                    healthPesho -= goshoDamage;
                    if (healthPesho > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                    }
                }

                if (healthGosho <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    return;
                }
                else if (healthPesho <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    return;
                }
                if (round % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
        }
    }
}

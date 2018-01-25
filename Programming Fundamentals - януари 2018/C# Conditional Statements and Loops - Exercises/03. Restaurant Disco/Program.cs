using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Disco
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();

            double price = 0;
            var typeHouse = "";

            if (peoples <= 50)
            {
                price = 2500;
                typeHouse = "Small Hall";
            }
            else if (peoples <= 100)
            {
                price = 5000;
                typeHouse = "Terrace";
            }
            else if (peoples <= 120)
            {
                price = 7500;
                typeHouse = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (type == "Normal")
            {
                price += 500;
                price *= 0.95;
            }
            else if (type == "Gold")
            {
                price += 750;
                price *= 0.9;
            }
            else if (type == "Platinum")
            {
                price += 1000;
                price *= 0.85;
            }
            price /= peoples;
            Console.WriteLine($"We can offer you the {typeHouse}");
            Console.WriteLine($"The price per person is {price:f2}$");
        }
    }
}

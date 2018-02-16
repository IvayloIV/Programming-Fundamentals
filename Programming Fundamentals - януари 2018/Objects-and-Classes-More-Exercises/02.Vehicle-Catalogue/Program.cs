using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
    class Program
    {
        class Vihicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
            public Vihicle(string type, string model, string color, int horsepower)
            {
                Type = type;
                Model = model;
                Color = color;
                Horsepower = horsepower;
            }
        }
        static void Main(string[] args)
        {
            var book = new List<Vihicle>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var inputTokens = input.Split(' ').ToArray();
                var type = "";
                if (inputTokens[0].ToLower() == "car")
                {
                    type = "Car";
                }
                else
                {
                    type = "Truck";
                }
                book.Add(new Vihicle(type, inputTokens[1], inputTokens[2], int.Parse(inputTokens[3])));
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }
                foreach (var item in book.Where(a => a.Model == input))
                {
                    Console.WriteLine($"Type: {item.Type}");
                    Console.WriteLine($"Model: {item.Model}");
                    Console.WriteLine($"Color: {item.Color}");
                    Console.WriteLine($"Horsepower: {item.Horsepower}");
                }
            }
            var allCars = book.Where(a => a.Type == "Car");
            var allTrucks = book.Where(a => a.Type == "Truck");
            if (allCars.Count() > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {(allCars.Average(a => a.Horsepower)):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (allTrucks.Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {(allTrucks.Average(a => a.Horsepower)):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}

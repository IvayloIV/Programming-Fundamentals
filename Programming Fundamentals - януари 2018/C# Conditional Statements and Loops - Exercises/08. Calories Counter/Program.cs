using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var calories = 0;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "cheese")
                {
                    calories += 500;
                }
                else if (input == "tomato sauce")
                {
                    calories += 150;
                }
                else if (input == "salami")
                {
                    calories += 600;
                }
                else if (input == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}

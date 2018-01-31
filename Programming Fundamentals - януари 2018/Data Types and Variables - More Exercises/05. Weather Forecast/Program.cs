using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var currentNum = long.Parse(Console.ReadLine());

                if ((currentNum >= sbyte.MinValue && currentNum <= sbyte.MaxValue) ||
                    (currentNum >= byte.MinValue && currentNum <= byte.MaxValue))
                {
                    Console.WriteLine($"Sunny");
                }
                else if (currentNum >= int.MinValue && currentNum <= int.MaxValue)
                {
                    Console.WriteLine($"Cloudy");
                }
                else
                {
                    Console.WriteLine($"Windy");
                }
            }
            catch 
            {
                Console.WriteLine($"Rainy");                
            }
        }
    }
}

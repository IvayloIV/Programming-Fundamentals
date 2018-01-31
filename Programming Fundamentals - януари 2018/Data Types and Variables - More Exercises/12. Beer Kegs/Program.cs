using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var maxVolume = Double.MinValue;
            var maxVolumeNmae = "";
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                var volume = Math.PI * radius * radius * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxVolumeNmae = name;
                }
            }
            Console.WriteLine(maxVolumeNmae);
        }
    }
}

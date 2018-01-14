using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInputsAndCalculate();
        }

        private static void ReadInputsAndCalculate()
        {
            var surface1 = Console.ReadLine();
            var mantle1 = Console.ReadLine();
            var core = Console.ReadLine();
            var mantle2 = Console.ReadLine();
            var surface2 = Console.ReadLine();

            MakeChecksOnInput(surface1, mantle1, core, mantle2, surface2);          
        }

        private static void MakeChecksOnInput(string surface1, 
            string mantle1, 
            string core, 
            string mantle2, 
            string surface2)
        {
            var regexSurface = @"^[^A-Za-z0-9]+$";
            var findingMantle = @"^[0-9_]+$";
            var findingCore = @"^[^A-Za-z0-9]+[0-9_]+([A-Za-z]+)[0-9_]+[^A-Za-z0-9]+$";

            Match findingSurface1 = Regex.Match(surface1, regexSurface);
            Match findingSurface2 = Regex.Match(surface2, regexSurface);
          
            Match findingMantle1 = Regex.Match(mantle1, findingMantle);
            Match findingMantle2 = Regex.Match(mantle2, findingMantle);
           
            Match findingCore1 = Regex.Match(core, findingCore);
           
            PrintResult(findingSurface1, findingSurface2, findingMantle1, findingMantle2, findingCore1);
        }

        private static void PrintResult(Match findingSurface1, 
            Match findingSurface2, 
            Match findingMantle1, 
            Match findingMantle2,
            Match findingCore1)
        {
            if (!findingCore1.Success || 
                !findingMantle1.Success || 
                !findingMantle1.Success || 
                !findingSurface1.Success || 
                !findingSurface2.Success)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine($"Valid");
                Console.WriteLine(findingCore1.Groups[1].Value.Length);
            }
        }
    }
}

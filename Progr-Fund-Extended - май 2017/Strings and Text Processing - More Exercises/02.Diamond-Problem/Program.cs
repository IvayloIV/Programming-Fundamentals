using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var index = input.IndexOf("<", 0);
            var ifContainsDiamond = false;
            while (index != -1)
            {
                var indexOfClose = input.IndexOf(">", index + 1);
                if (indexOfClose == -1)
                {
                    break;
                }
                else
                {
                    var currentDiamond = input.Substring(index + 1, indexOfClose - index - 1);
                    var carats = 0;
                    for (int i = 0; i < currentDiamond.Length; i++)
                    {
                        if (currentDiamond[i] >= 48 && currentDiamond[i] <= 57)
                        {
                            carats += int.Parse(currentDiamond[i].ToString());
                        }
                    }
                    Console.WriteLine($"Found {carats} carat diamond");
                    ifContainsDiamond = true;
                }
                index = input.IndexOf("<", indexOfClose + 1);
            }
            if (!ifContainsDiamond) Console.WriteLine("Better luck next time");
        }
    }
}

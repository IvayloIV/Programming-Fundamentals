using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            MatchCollection smileFaces = Regex.Matches(input, @"(:\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;)");
            MatchCollection sadFaces = Regex.Matches(input, @"(:\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|];)");
            var smileFacesCount = smileFaces.Count;
            var sadFacesCount = sadFaces.Count;
            var happinessIndex = (double)smileFacesCount / sadFacesCount;
            var typeHappiness = GetTypeHappiness(happinessIndex);
            Console.WriteLine($"Happiness index: {happinessIndex:f2} {typeHappiness}");
            Console.WriteLine($"[Happy count: {smileFacesCount}, Sad count: {sadFacesCount}]");
        }

        private static string GetTypeHappiness(double happinessIndex)
        {
            if (happinessIndex >= 2)
            {
                return ":D";
            }
            else if (happinessIndex > 1)
            {
                return ":)";
            }
            else if (happinessIndex == 1)
            {
                return ":|";
            }
            else
            {
                return ":(";
            }
        }
    }
}

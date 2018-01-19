using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var teamTehnical = 0D;
            var teamTheoretical = 0D;
            var teamPractical = 0D;

            for (int i = 0; i < n; i++)
            {
                var distanceInMetres = double.Parse(Console.ReadLine()) * 1600;
                var cargoKilograms = double.Parse(Console.ReadLine()) * 1000;
                var team = Console.ReadLine();

                var earningMoney = (cargoKilograms * 1.5) - (0.7 * distanceInMetres * 2.5);
                if (team == "Technical")
                {
                    teamTehnical += earningMoney;
                }
                else if (team == "Theoretical")
                {
                    teamTheoretical += earningMoney;
                }
                else if (team == "Practical")
                {
                    teamPractical += earningMoney;
                }
            }
            PringResult(teamTehnical, teamTheoretical, teamPractical);
        }

        private static void PringResult(double teamTehnical, double teamTheoretical, double teamPractical)
        {
            if (teamTehnical > teamTheoretical && teamTehnical > teamPractical)
            {
                Console.WriteLine($"The Technical Trainers win with ${teamTehnical:f3}.");
            }
            else if (teamPractical > teamTehnical && teamPractical > teamTheoretical)
            {
                Console.WriteLine($"The Practical Trainers win with ${teamPractical:f3}.");
            }
            else
            {
                Console.WriteLine($"The Theoretical Trainers win with ${teamTheoretical:f3}.");
            }
        }
    }
}

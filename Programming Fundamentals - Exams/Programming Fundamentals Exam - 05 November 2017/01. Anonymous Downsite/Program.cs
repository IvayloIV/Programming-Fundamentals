using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var n = int.Parse(Console.ReadLine());
            var securityToken = int.Parse(Console.ReadLine());

            decimal sum = ClaculateAllLosses(n, securityToken);

            Console.WriteLine($"Total Loss: {sum:f20}");

            CalculateAndPrintTokens(securityToken, n);
        }

        private static decimal ClaculateAllLosses(int n, int securityToken)
        {
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var siteName = input[0];
                var siteVisits = decimal.Parse(input[1]);
                var siteCommercial = decimal.Parse(input[2]);
                Console.WriteLine(siteName);
                sum += (siteVisits * siteCommercial);
            }
            return sum;
        }

        private static void CalculateAndPrintTokens(int securityToken, int n)
        {
            BigInteger token = securityToken;
            for (int i = 0; i < n - 1; i++)
            {
                token *= securityToken;
            }
            Console.WriteLine($"Security Token: {token}");
        }
    }
}

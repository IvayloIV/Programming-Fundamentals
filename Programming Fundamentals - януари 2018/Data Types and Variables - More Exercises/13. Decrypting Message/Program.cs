using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var text = "";
            for (int i = 0; i < n; i++)
            {
                text += (char)(char.Parse(Console.ReadLine()) + key);
            }
            Console.WriteLine(text);
        }
    }
}

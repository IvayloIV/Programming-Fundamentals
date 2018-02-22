using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stateless
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var text = Console.ReadLine();
                if (text == "collapse") break;
                var deletePatter = Console.ReadLine();
                var isVoid = false;
                while (true)
                {
                    var index = text.IndexOf(deletePatter);
                    while (index != -1)
                    {
                        text = text.Remove(index, deletePatter.Length);
                        index = text.IndexOf(deletePatter, index);
                    }
                    if (text == "")
                    {
                        Console.WriteLine($"(void)");
                        isVoid = true;
                        break;
                    }
                    deletePatter = deletePatter.Remove(deletePatter.Length - 1, 1);
                    if (deletePatter == "")
                    {
                        break;
                    }
                    deletePatter = deletePatter.Remove(0, 1);
                    if (deletePatter == "")
                    {
                        break;
                    }
                }
                if (!isVoid)
                {
                    Console.WriteLine(text.Trim());
                }
            }
        }
    }
}

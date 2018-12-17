using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Ecrivez un nombre puis appuyer sur entrée");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ecrivez un nombre puis appuyer syr entrée");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a + " et b=" + b);

        }
    }
}

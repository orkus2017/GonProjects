using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171128_1_ATortasConEl_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            bool power = false;
            int balas = -3;

            if (balas == 0)
            {
                Console.WriteLine("No tengo Power!!!");
            }
            else if (balas == 1)
            {
                Console.WriteLine("Tengo un poco de power!!!");
            }
            else if (balas == 2)
            {
                Console.WriteLine("Tengo algo de power!!!");
            }
            else
            {
                Console.WriteLine("Tengo mazo de power!!!");
            }

            Console.WriteLine("Hum....");

            Console.ReadKey();
        }
    }
}

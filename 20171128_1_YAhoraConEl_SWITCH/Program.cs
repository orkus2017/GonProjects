using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171128_1_YAhoraConEl_SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            bool power = false;
            int balas = 2;

            switch (balas)
            {
                case 0:
                    Console.WriteLine("No tengo Power!!!");
                    break;
                case 1:
                    Console.WriteLine("Tengo un poco de power!!!");
                    break;
                case 2:
                    Console.WriteLine("Tengo algo de power!!!");
                    break;
                case 3:
                    Console.WriteLine("Tengo 3 powers!!!");
                    break;
                default:
                    Console.WriteLine("Tengo mazo de power!!!");
                    break;
            }

            Console.WriteLine("Hum....");

            Console.ReadKey();
        }
    }
}

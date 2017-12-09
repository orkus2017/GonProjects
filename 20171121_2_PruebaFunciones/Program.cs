using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171121_2_PruebaFunciones
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int n = 1; n <= 3; n++)

            {
                string cadena = HazLaPregunta();

                Console.WriteLine(cadena);


            }

            Console.ReadKey();
        }

        private static string HazLaPregunta()
        {
            Console.WriteLine("Escribe tres veces lo que tu desees.");


            Console.WriteLine();

            string cadena = Console.ReadLine();

            return cadena;
        }
    }
}

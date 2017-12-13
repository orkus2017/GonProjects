using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_12_01_PruebaConGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            PruebaDeFuncion("¡¡Hola mundo!! 2");

            Console.ReadKey();
        }

        private static void PruebaDeFuncion(string paramString)
        {
            Console.WriteLine("");
            Console.WriteLine("Llamada a PruebaDeFuncion");
            Console.WriteLine("Parámetro enviado: '" + paramString + "'");
            Console.WriteLine("");
        }
    }
}

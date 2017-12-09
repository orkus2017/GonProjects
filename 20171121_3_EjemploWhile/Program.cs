using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171121_3_EjemploWhile
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = 0;
            while (n < 3)
            {

                Console.WriteLine("Escribe tres veces los que quieras");
                Console.WriteLine();

                string cadena = Console.ReadLine();



                Console.WriteLine(cadena);
                n++;
            }

            Console.ReadKey();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171121_4_EjemploDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            do
            {

                Console.WriteLine("Escribe tres veces los que quieras");
                Console.WriteLine();


                string cadena = Console.ReadLine();



                Console.WriteLine(cadena);
                n++;
            } while (n < 3);

            Console.ReadKey();





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171128_2_EjercicioPractico_if_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Escibre la clave");

                string cadena = "";
                cadena = Console.ReadLine();

                if (cadena == "exit")
                {


                    break;
                }




            } while (true);

            Console.WriteLine("Muy bien");
            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();

        }
    }
}

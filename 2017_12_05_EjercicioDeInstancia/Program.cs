using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_05_EjercicioDeInstancia
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vamos a empezar la instancia ROCANEGRA.\n ¿Que combinación de equipo es la mas efectiva?");

            Console.WriteLine("La opción 1 es: Tanke,Healer,Healer,DPS,Tanke.");
            Console.WriteLine("La opción 2 es: Tanke,Healer,Tanke,DPS,Tanke.");
            Console.WriteLine("La opción 3 es: Tanke,Healer,DPS,DPS,Tanke.");
            Console.WriteLine("La opción 4 es: Tanke,Healer,DPS,DPS,DPS.");
            Console.WriteLine("La opción 5 es: Tanke,Healer,Healer,Tanke,Tanke.");
            Console.WriteLine("La opción 6 es: Tanke,Healer,Tanke,Tanke,Tanke.");

            do
            {
                string cadena = "";

                cadena = Console.ReadLine();

                int n = Convert.ToInt32(cadena);

                if (n == 1)
                {
                    Console.WriteLine("Esta opción no es la correcta.");
                    Console.WriteLine("En esta configuración falta daño y sobra curaciones.");
                }
                else if (n == 2)
                {
                    Console.WriteLine("Esta opción no es la correcta.");
                    Console.WriteLine("En Esta combinación te falta daño y tienes demasiados Tankes.");
                }
                else if (n == 3)
                {
                    Console.WriteLine("Esta opción no es la correcta.");
                    Console.WriteLine("Esta configuración esta casi equilibrada.");
                }
                else if (n == 4)
                {
                    Console.WriteLine("Enhorabuena esta es la configuración perfecta!");
                    Console.WriteLine("Ahora empieza la verdadera aventura, pon atención y no seas Paco!");

                    break;
                }
                else if (n == 5)
                {
                    Console.WriteLine("Esta opción no es la correcta.");
                    Console.WriteLine("Esta configuración tiene demasiados Tankes y le falta mucho daño.");
                }
                Console.WriteLine("Prueba otra combinación.");
            } while (true);

            Console.ReadKey();

        }
    }
}

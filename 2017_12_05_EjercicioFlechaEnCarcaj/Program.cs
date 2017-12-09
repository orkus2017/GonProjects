using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_05_EjercicioFlechaEnCarcaj
{
    class Program
    {
        static void Main(string[] args)
        {

            do {

                Console.WriteLine("¿Cuantas flechas caben en este carcaj?");

                string cadena = "";

                cadena = Console.ReadLine();

                int n = Convert.ToInt32(cadena);

                if (n < 20)
                {

                    Console.WriteLine("No es el numero correto de flechas que caben en el carcaj");

             
                } 
                else if (n > 20)
                {

                    Console.WriteLine("Sobrepasa el numero maximo de flechas que puede almacenar el carcaj.");


                }
                else if (n == 20)
                {

                    Console.WriteLine("Enhorabuena es el numero exacto de flechas que puede almacenar el carcaj");
                    



                    break;
                }
                








            } while (true);
            Console.WriteLine("Bien ahora podemos empezar con la aventura!");
            Console.ReadKey();


        }
    }
}

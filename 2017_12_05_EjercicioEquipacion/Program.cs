using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_05_EjercicioEquipacion
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine("¿Que llevamos para completar esta Dungeond?");

                string cadena = Console.ReadLine();

                if (cadena == "espada")
                {
                    Console.WriteLine("Perfecto servira para masacrar a nuestros enemigos");
                }
                else if (cadena == "mochila")
                {
                    Console.WriteLine("Bien podremos cargar los ingredientes, armas y tesoros");
                }
                else if (cadena == "antorcha")
                {
                    Console.WriteLine("Probablemente lo mas necesario ademas de la comida para nuestras aventuras");
                }
            }

            Console.WriteLine("Si ya tienes todo tu equipo preparado, adentremonos en la Dungeond a por aventuras");
            Console.ReadKey();
        }
    }
}

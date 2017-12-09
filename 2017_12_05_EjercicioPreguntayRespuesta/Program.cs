using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_12_05_EjercicioPreguntayRespuesta
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("¿Que llevas en la mochila?");

                string cadena = "";

                cadena = Console.ReadLine();
                if (
                    cadena == "antorcha"

                    )

                {
                    Console.WriteLine("Vamonos de Dungeons!");
                    break;
                    

                }







            } while (true);



            Console.ReadKey();

                



        }
    }
}

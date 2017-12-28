//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 22-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Singleton
//  El objetivo es aprender de que va y usar este patrón
//
//  Scrumming: https://gonprojects.visualstudio.com
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_001_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton onj = new Singleton();//Esto da error por que el constructor es privado

            //Esto va bien:
            string mensaje = "";

            mensaje = Singleton.Instance.Saluda();
            Console.WriteLine(mensaje);

            //Bucle 10 repeticiones
            for (int m = 0; m < 10; m++)
            {
                mensaje = Singleton.Instance.Saluda();
                Console.WriteLine(mensaje);
            }

            Console.WriteLine();
            Console.WriteLine("Pulsa una tecla para terminar...");
            Console.ReadKey();
        }
    }
}

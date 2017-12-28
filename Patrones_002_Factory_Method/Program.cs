//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 26-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Factory Method
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: https://msdn.microsoft.com/en-us/library/ee817667.aspx
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_002_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerFactory factory = null;

            //Ejemplo 1

            //factory = new ConcreteComputerFactory();

            //Ejemplo 2

            Console.WriteLine("Elige un tipo:");
            Console.WriteLine();
            Console.WriteLine("1.- ComputerFactory");
            Console.WriteLine("2.- BrandXFactory");

            string tipo = Console.ReadLine();

            if (tipo == "1")
                factory = new ConcreteComputerFactory();
            else
                factory = new BrandXFactory();

            //Esto es común a ambos ejemplos

            new ComputerAssembler().AssembleComputer(factory);

            Console.WriteLine();
            Console.WriteLine("Pulsa una tecla para terminar...");
            Console.ReadKey();
        }
    }
}

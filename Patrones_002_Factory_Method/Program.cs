//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 26-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Factory Method
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: https://msdn.microsoft.com/en-us/library/ee817667.aspx
//  Más información: http://www.dofactory.com/net/factory-method-design-pattern
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//  Define an interface for creating an object, but let subclasses decide which 
//  class to instantiate.Factory Method lets a class defer instantiation to subclasses.
//  
//  Frecuencia de uso (1-5): 5
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

    class BrandXComputer : Computer
    {

        int _mhz = 1500;

        public override int Mhz
        {

            get { return _mhz; }

        }//Mhz

    }//BrandXComputer

    class BrandXFactory : ComputerFactory
    {

        public override Computer GetComputer()
        {

            return new BrandXComputer();

        }//GetComputer

    }//BrandXFactory

    abstract class Computer
    {

        public abstract int Mhz { get; }

    }//Computer

    class ComputerAssembler
    {

        public void AssembleComputer(ComputerFactory factory)
        {

            Computer computer = factory.GetComputer();
            Console.WriteLine("assembled a {0} running at {1} MHz",
               computer.GetType().FullName, computer.Mhz);

        }//AssembleComputer

    }//ComputerAssembler

    abstract class ComputerFactory
    {

        public abstract Computer GetComputer();

    }//ComputerFactory

    class ConcreteComputer : Computer
    {

        int _mhz = 500;

        public override int Mhz
        {

            get { return _mhz; }

        }//Mhz

    }//ConcreteComputer

    class ConcreteComputerFactory : ComputerFactory
    {

        public override Computer GetComputer()
        {

            return new ConcreteComputer();

        }//GetComputer

    }//ConcreteComputerFactory
}

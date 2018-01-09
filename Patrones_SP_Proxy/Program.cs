﻿//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 28-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Proxy
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: http://www.dofactory.com/net/proxy-design-pattern
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//  Provide a surrogate or placeholder for another object to control access to it.
//  
//  Frecuencia de uso (1-5): 4
//
//  This real-world code demonstrates the Proxy pattern for a Math object represented 
//  by a MathProxy object.
//
//////////////////////////////////////////////////////////////////////////////

using System;

namespace Patrones_SP_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create math proxy

            MathProxy proxy = new MathProxy();

            // Do the math

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Subject interface
    /// </summary>

    public interface IMath
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }

    /// <summary>
    /// The 'RealSubject' class
    /// </summary>

    class Math : IMath
    {
        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mul(double x, double y) { return x * y; }
        public double Div(double x, double y) { return x / y; }
    }

    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>

    class MathProxy : IMath
    {
        private Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }
        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }
        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }
        public double Div(double x, double y)
        {
            return _math.Div(x, y);
        }
    }
}

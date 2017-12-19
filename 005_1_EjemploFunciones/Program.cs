//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny y Gon
//  Creado: 19-12-2017
//  Este es un ejemplo de hacer funciones. Sencillito
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_1_EjemploFunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program prog = new Program();

            //EscribeTexto();

            //EscribeTextoConParametros(SumaDeEnteros(5, 8).ToString());

            //EscribeTextoConParametros(RestaDeEnteros(25, 15).ToString());

            //EscribeTextoConParametros(MultiplicacionDeEnteros(5, 5).ToString());

            //EscribeTextoConParametros(DivisionDeEnteros(50, 10).ToString());

            //CalculaTodo(5, 10);
            Calculadora calc = new Calculadora();

            //EscribeTextoConParametros(calc.SumaDeEnteros(1, 2).ToString());

            //Este es un comentario

            calc.PreguntaNumerosYCalculaTodo();

            Console.ReadKey();
        }

        static void EscribeTexto()
        {
            Console.WriteLine();
            Console.WriteLine("Hola Gon");
            Console.WriteLine();
            Console.WriteLine();
        }

        static void EscribeTextoConParametros(string texto)
        {
            // Esta funcion te escribe lo que le pasas en texto
            Console.WriteLine();
            Console.WriteLine("El texto es: " + texto);
            Console.WriteLine("Escribo otra vez: " + texto);
            Console.WriteLine();
        }

        static string DuplicarCadena(string cadena)
        {
            return cadena + cadena;
        }


        static int SumaDeEnteros(int a, int b)
        {

            return a + b;

        }

        static int RestaDeEnteros(int w, int e)
        {

            return w - e;
        }

        static int MultiplicacionDeEnteros(int a, int b)
        {


            return a * b;
        }

        static int DivisionDeEnteros(int a, int b)
        {

            return a / b;

        }

        static void CalculaTodo(int a, int b)
        {


            Console.WriteLine("La suma es:" + SumaDeEnteros(a, b));
            Console.WriteLine("La resta es:" + RestaDeEnteros(a, b));
            Console.WriteLine("La Multiplicación es:" + MultiplicacionDeEnteros(a, b));
            Console.WriteLine("La División es:" + DivisionDeEnteros(a, b));
        }

    }
}

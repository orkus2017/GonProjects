using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_1_EjemploFunciones
{
    public class Calculadora
    {
        public void PreguntaNumerosYCalculaTodo()
        {
            Console.WriteLine("Escribe los numeros que quieres sumar:");
            Console.Write("Primer numero:");

            string a = Console.ReadLine();

            Console.Write("Segundo numero:");
            string b = Console.ReadLine();

            int n1 = Convert.ToInt32(a);
            int n2 = Convert.ToInt32(b);

            CalculaTodo(n1, n2);
        }

        public string DuplicarCadena(string cadena)
        {
            return cadena + cadena;
        }

        public int SumaDeEnteros(int a, int b)
        {
            return a + b;
        }

        public int RestaDeEnteros(int w, int e)
        {
            return w - e;
        }

        public int MultiplicacionDeEnteros(int a, int b)
        {
            return a * b;
        }

        public int DivisionDeEnteros(int a, int b)
        {
            return a / b;
        }

        public void CalculaTodo(int a, int b)
        {
            Console.WriteLine("La suma es:" + SumaDeEnteros(a, b));
            Console.WriteLine("La resta es:" + RestaDeEnteros(a, b));
            Console.WriteLine("La Multiplicación es:" + MultiplicacionDeEnteros(a, b));
            Console.WriteLine("La División es:" + DivisionDeEnteros(a, b));
        }
    }
}

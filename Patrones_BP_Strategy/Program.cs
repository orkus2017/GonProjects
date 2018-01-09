//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 28-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Strategy
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: http://www.dofactory.com/net/strategy-design-pattern
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//  Define a family of algorithms, encapsulate each one, and make them interchangeable.
//  Strategy lets the algorithm vary independently from clients that use it.
//  
//  Frecuencia de uso (1-5): 4
//
//  This real-world code demonstrates the Strategy pattern which encapsulates sorting 
//  algorithms in the form of sorting objects.This allows clients to dynamically 
//  change sorting strategies including Quicksort, Shellsort, and Mergesort.
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace Patrones_BP_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two contexts following different strategies

            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>

    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort

            Console.WriteLine("QuickSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    class ShellSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented

            Console.WriteLine("ShellSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>

    class MergeSort : SortStrategy

    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented

            Console.WriteLine("MergeSorted list ");
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>

    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}

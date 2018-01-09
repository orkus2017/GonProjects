//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 28-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Iterator
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: http://www.dofactory.com/net/iterator-design-pattern
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//  Provide a way to access the elements of an aggregate object sequentially 
//  without exposing its underlying representation.
//
//  Frecuencia de uso (1-5): 5
//  
//  This real-world code demonstrates the Iterator pattern which is used to 
//  iterate over a collection of items and skip a specific number of items each 
//  iteration.
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_BP_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection

            Collection collection = new Collection();
            collection[0] = new Item("Item 0");
            collection[1] = new Item("Item 1");
            collection[2] = new Item("Item 2");
            collection[3] = new Item("Item 3");
            collection[4] = new Item("Item 4");
            collection[5] = new Item("Item 5");
            collection[6] = new Item("Item 6");
            collection[7] = new Item("Item 7");
            collection[8] = new Item("Item 8");

            // Create iterator

            Iterator iterator = collection.CreateIterator();

            // Skip every other item

            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for (Item item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// A collection item
    /// </summary>

    class Item
    {
        private string _name;

        // Constructor

        public Item(string name)
        {
            this._name = name;
        }

        // Gets name

        public string Name
        {
            get { return _name; }
        }
    }

    /// <summary>
    /// The 'Aggregate' interface
    /// </summary>

    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }

    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>

    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count

        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

    /// <summary>
    /// The 'Iterator' interface
    /// </summary>

    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>

    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        // Constructor

        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        // Gets first item

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        // Gets next item

        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;
            else

                return null;
        }

        // Gets or sets stepsize

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item

        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }

        // Gets whether iteration is complete

        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}

﻿//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 28-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Observer
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: http://www.dofactory.com/net/observer-design-pattern
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//  Define a one-to-many dependency between objects so that when one object changes 
//  state, all its dependents are notified and updated automatically.
//  
//  Frecuencia de uso (1-5): 5
//
//  This structural code demonstrates the Observer pattern in which registered 
//  objects are notified of and updated with a state change.
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace Patrones_BP_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IBM stock and attach investors

            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>

    abstract class Stock
    {
        private string _symbol;
        private double _price;
        private List<IInvestor> _investors = new List<IInvestor>();

        // Constructor

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Attach(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in _investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        // Gets or sets the price

        public double Price
        {
            get { return _price; }
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        // Gets the symbol

        public string Symbol
        {
            get { return _symbol; }
        }
    }

    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>

    class IBM : Stock
    {
        // Constructor

        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }

    /// <summary>
    /// The 'Observer' interface
    /// </summary>

    interface IInvestor
    {
        void Update(Stock stock);
    }

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>

    class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;

        // Constructor

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2:C}", _name, stock.Symbol, stock.Price);
        }

        // Gets or sets the stock

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}

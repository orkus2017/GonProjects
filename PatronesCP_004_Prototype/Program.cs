﻿//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 28-12-2017
//  Ejercicio de estudio de Patrones de Diseño: Prototype
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: http://www.dofactory.com/net/prototype-design-pattern
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//  Specify the kind of objects to create using a prototypical instance, 
//  and create new objects by copying this prototype.
//  
//  Frecuencia de uso (1-5): 3
//
//  This real-world code demonstrates the Prototype pattern in which new Color 
//  objects are created by copying pre-existing, user-defined Colors of the same type.
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;

namespace PatronesCP_004_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors

            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>

    abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>

    class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor

        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy

        public override ColorPrototype Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }
    }

    /// <summary>
    /// Prototype manager
    /// </summary>

    class ColorManager

    {
        private Dictionary<string, ColorPrototype> _colors =
          new Dictionary<string, ColorPrototype>();

        // Indexer

        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}

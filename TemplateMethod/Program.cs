//////////////////////////////////////////////////////////////////////////////
//
//  Por Ferny
//  Creado: 28-12-2017
//  Ejercicio de estudio de Patrones de Diseño: TemplateMethod
//  El objetivo es aprender de que va y usar este patrón
//
//  Encontrado: http://www.dofactory.com/net/template-method-design-pattern
//  
//  Scrumming: https://gonprojects.visualstudio.com
//
//  Define the skeleton of an algorithm in an operation, deferring some steps 
//  to subclasses.Template Method lets subclasses redefine certain steps of an 
//  algorithm without changing the algorithm's structure.
//  
//  Frecuencia de uso (1-5): 3
//
//  This real-world code demonstrates a Template method named Run() which provides
//  a skeleton calling sequence of methods.Implementation of these steps are deferred 
//  to the CustomerDataObject subclass which implements the Connect, Select, 
//  Process, and Disconnect methods.
//
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Data.OleDb;

namespace Patrones_BP_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>

    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app

            connectionString =
              "provider=Microsoft.JET.OLEDB.4.0; " +
              "data source=..\\..\\..\\db1.mdb";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method' 

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>

    class Categories : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>

    class Products : DataAccessObject
    {
        public override void Select()
        {
            string sql = "select ProductName from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Products");
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }
    }
}

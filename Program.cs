using DesignPatternsTraining.BuilderDesignPattern;
using DesignPatternsTraining.FactoryMethod;
using DesignPatternsTraining.Singleton;
using System;
using System.Collections.Generic;

namespace DesignPatternsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Singleton Design Pattern
            /*
            var db = SingletonDataContainer.Instance;
            Console.WriteLine(db.GetPopulation("Washington, D.C."));
            var db2 = SingletonDataContainer.Instance;
            Console.WriteLine(db2.GetPopulation("London"));
            */


            ////Factory Design Pattern
            /*
            var factory = new AirConditioner().ExecuteCreation(Actions.Cooling, 22.5);
            factory.Operate();
            */


            ////Builder Design Pattern
            var products = new List<Product>
            {
                new Product { Name = "Monitor", Price = 200.50 },
                new Product { Name = "Mouse", Price = 20.41 },
                new Product { Name = "Keyboard", Price = 30.15}
            };

            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetReport();
            Console.WriteLine(report);

            



            Console.ReadLine();
        }
    }
}

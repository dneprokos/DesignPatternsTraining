using DesignPatternsTraining.Singleton;
using System;

namespace DesignPatternsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton example
            var db = SingletonDataContainer.Instance;
            Console.WriteLine(db.GetPopulation("Washington, D.C."));
            var db2 = SingletonDataContainer.Instance;
            Console.WriteLine(db2.GetPopulation("London"));


            Console.ReadLine();
        }
    }
}

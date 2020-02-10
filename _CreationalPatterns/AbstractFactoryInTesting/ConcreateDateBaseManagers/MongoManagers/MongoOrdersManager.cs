using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractDataBaseManagers;
using System;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateDateBaseManagers.MongoManagers
{
    public class MongoOrdersManager : IOrdersManager
    {
        public void CreateOrder()
        {
            Console.WriteLine("#####Order Creation#####");
            Console.WriteLine("Order was created at MongoDB\n");
        }

        public void DeleteOrder()
        {
            Console.WriteLine("#####Order Deletion#####");
            Console.WriteLine("Order was removed from MongoDB\n");
        }
    }
}

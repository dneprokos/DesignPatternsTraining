using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractDataBaseManagers;
using System;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateDateBaseManagers.SqlManagers
{
    public class SqlOrdersManager : IOrdersManager
    {
        public void CreateOrder()
        {
            Console.WriteLine("#####Order Creation#####");
            Console.WriteLine("Order was created at SQL DB\n");
        }

        public void DeleteOrder()
        {
            Console.WriteLine("#####Order Delettion#####");
            Console.WriteLine("Order was removed from SQL DB\n");
        }
    }
}

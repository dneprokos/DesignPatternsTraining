using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractDataBaseManagers;
using System;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateDateBaseManagers.MongoManagers
{
    public class MongoAccountsManager : IAccountsManager
    {
        public void CreateAccount()
        {
            Console.WriteLine("#####Account Creation#####");
            Console.WriteLine("Account was created at Mongo DB\n");
        }

        public void DeleteAccount()
        {
            Console.WriteLine("#####Account Creation#####");
            Console.WriteLine("Account was created from Mongo DB\n");
        }
    }
}

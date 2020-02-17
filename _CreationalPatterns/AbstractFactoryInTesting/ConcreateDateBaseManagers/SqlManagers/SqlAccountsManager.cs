using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractDataBaseManagers;
using System;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateDateBaseManagers.SqlManagers
{
    public class SqlAccountsManager : IAccountsManager
    {
        public void CreateAccount()
        {
            Console.WriteLine("#####Account Creation#####");
            Console.WriteLine("Account was created at SQL DB\n");
        }

        public void DeleteAccount()
        {
            Console.WriteLine("#####Account Creation#####");
            Console.WriteLine("Account was deleted from SQL DB\n");
        }
    }
}

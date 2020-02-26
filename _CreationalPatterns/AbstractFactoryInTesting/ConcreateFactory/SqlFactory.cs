using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractDataBaseManagers;
using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractFactory;
using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateDateBaseManagers.SqlManagers;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateFactory
{
    public class SqlFactory : IDataBaseSetupFactory
    {
   
        public IAccountsManager CreateAccountManager()
        {
            return new SqlAccountsManager();
        }

        public IOrdersManager CreateOrderManager()
        {
            return new SqlOrdersManager();
        }
        
    }
}

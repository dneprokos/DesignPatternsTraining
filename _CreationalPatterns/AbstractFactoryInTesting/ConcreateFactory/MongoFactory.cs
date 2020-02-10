using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractDataBaseManagers;
using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractFactory;
using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateDateBaseManagers.MongoManagers;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.ConcreateFactory
{
    public class MongoFactory : IDataBaseSetupFactory
    {
        public IAccountsManager CreateAccountManager()
        {
            return new MongoAccountsManager();
        }

        public IOrdersManager CreateOrderManager()
        {
            return new MongoOrdersManager();
        }
    }
}

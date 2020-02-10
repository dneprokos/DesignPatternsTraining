using DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractDataBaseManagers;

namespace DesignPatternsTraining._CreationalPatterns.AbstractFactoryInTesting.AbstractFactory
{
    public interface IDataBaseSetupFactory
    {
        IAccountsManager CreateAccountManager();
        IOrdersManager CreateOrderManager();
    }
}
